using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using UnityEngine;

namespace MetaMystia.Debugger
{
    public static class ReflectionEvaluator
    {
        public static object Evaluate(string expression)
        {
            if (string.IsNullOrWhiteSpace(expression)) return null;
            try
            {
                var parser = new ExpressionParser(expression);
                return parser.Evaluate();
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }
    }

    public class ExpressionParser
    {
        private readonly string _text;
        private int _pos;

        public ExpressionParser(string text)
        {
            _text = text;
            _pos = 0;
        }

        public object Evaluate()
        {
            object current = ParseRoot();

            while (_pos < _text.Length)
            {
                SkipWhitespace();
                if (_pos >= _text.Length) break;

                char c = _text[_pos];
                if (c == '.')
                {
                    _pos++; // Consume '.'
                    string memberName = ParseIdentifier();
                    
                    SkipWhitespace();
                    if (_pos < _text.Length && _text[_pos] == '(')
                    {
                        var args = ParseArgumentList('(', ')');
                        current = InvokeMethodOnTarget(current, memberName, args);
                    }
                    else
                    {
                        current = AccessMember(current, memberName);
                    }
                }
                else if (c == '[')
                {
                    var args = ParseArgumentList('[', ']');
                    current = AccessIndexer(current, args);
                }
                else
                {
                    break;
                }
            }

            return current;
        }

        private object ParseRoot()
        {
            SkipWhitespace();
            if (_pos >= _text.Length) return null;

            char c = _text[_pos];

            // 1. Literals
            if (c == '"') return ParseStringLiteral();
            if (char.IsDigit(c) || c == '-') return ParseNumberLiteral();
            
            // 2. Identifiers (could be Type, Static Class, or bool/null)
            string ident = ParseIdentifier();
            
            if (ident == "true") return true;
            if (ident == "false") return false;
            if (ident == "null") return null;

            // 3. Type Resolution
            List<string> parts = new List<string> { ident };
            
            // Look ahead to capture A.B.C
            while (_pos < _text.Length)
            {
                int savePos = _pos;
                SkipWhitespace();
                if (_pos < _text.Length && _text[_pos] == '.')
                {
                    _pos++; // Consume '.'
                    parts.Add(ParseIdentifier());
                }
                else
                {
                    _pos = savePos; // Backtrack if not dot
                    break;
                }
            }

            // Now try to find the longest prefix that is a Type
            for (int i = parts.Count; i > 0; i--)
            {
                string typeName = string.Join(".", parts.Take(i));
                Type type = FindType(typeName);
                if (type != null)
                {
                    object current = null; // Static context initially
                    Type currentType = type;

                    // Process the remaining parts that were tentatively parsed as type name
                    for (int j = i; j < parts.Count; j++)
                    {
                        string memberName = parts[j];
                        bool isLast = (j == parts.Count - 1);
                        
                        if (isLast)
                        {
                            SkipWhitespace();
                            if (_pos < _text.Length && _text[_pos] == '(')
                            {
                                var args = ParseArgumentList('(', ')');
                                current = InvokeMethodOnTarget(currentType, current, memberName, args);
                                if (current != null) currentType = current.GetType();
                                continue;
                            }
                        }
                        
                        current = AccessMember(currentType, current, memberName);
                        if (current != null) currentType = current.GetType();
                    }
                    
                    return current ?? type; 
                }
            }

            throw new Exception($"Could not resolve type or identifier '{ident}'");
        }

        private object[] ParseArgumentList(char open, char close)
        {
            _pos++; // Consume open char
            List<object> args = new List<object>();
            
            SkipWhitespace();
            if (_pos < _text.Length && _text[_pos] == close)
            {
                _pos++;
                return args.ToArray();
            }

            while (_pos < _text.Length)
            {
                string argExpr = ReadUntilDelimiter(new char[] { ',', close });
                var subParser = new ExpressionParser(argExpr);
                args.Add(subParser.Evaluate());

                SkipWhitespace();
                if (_pos < _text.Length && _text[_pos] == ',')
                {
                    _pos++; // Consume comma
                }
                else if (_pos < _text.Length && _text[_pos] == close)
                {
                    _pos++; // Consume close
                    break;
                }
            }
            return args.ToArray();
        }

        private string ReadUntilDelimiter(char[] delimiters)
        {
            int start = _pos;
            int depthParen = 0;
            int depthBracket = 0;
            bool inQuote = false;

            while (_pos < _text.Length)
            {
                char c = _text[_pos];
                
                if (inQuote)
                {
                    if (c == '"' && _text[_pos-1] != '\\') inQuote = false;
                }
                else
                {
                    if (c == '"') inQuote = true;
                    else if (c == '(') depthParen++;
                    else if (c == ')') depthParen--;
                    else if (c == '[') depthBracket++;
                    else if (c == ']') depthBracket--;
                    else if (depthParen == 0 && depthBracket == 0 && delimiters.Contains(c))
                    {
                        break;
                    }
                }
                _pos++;
            }
            
            return _text.Substring(start, _pos - start);
        }

        private string ParseIdentifier()
        {
            SkipWhitespace();
            int start = _pos;
            if (_pos < _text.Length && (char.IsLetter(_text[_pos]) || _text[_pos] == '_'))
            {
                _pos++;
                while (_pos < _text.Length && (char.IsLetterOrDigit(_text[_pos]) || _text[_pos] == '_'))
                {
                    _pos++;
                }
                return _text.Substring(start, _pos - start);
            }
            throw new Exception($"Expected identifier at position {start}");
        }

        private string ParseStringLiteral()
        {
            _pos++; // Consume "
            int start = _pos;
            while (_pos < _text.Length && _text[_pos] != '"')
            {
                if (_text[_pos] == '\\') _pos++; // Skip escape
                _pos++;
            }
            string res = _text.Substring(start, _pos - start);
            _pos++; // Consume "
            return res;
        }

        private object ParseNumberLiteral()
        {
            int start = _pos;
            if (_text[_pos] == '-') _pos++;
            while (_pos < _text.Length && (char.IsDigit(_text[_pos]) || _text[_pos] == '.'))
            {
                _pos++;
            }
            string numStr = _text.Substring(start, _pos - start);
            if (numStr.Contains(".")) return double.Parse(numStr);
            return int.Parse(numStr);
        }

        private void SkipWhitespace()
        {
            while (_pos < _text.Length && char.IsWhiteSpace(_text[_pos])) _pos++;
        }

        // --- Reflection Helpers ---

        private static Type FindType(string name)
        {
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                var type = assembly.GetType(name);
                if (type != null) return type;
            }
            return null;
        }

        private object AccessMember(object target, string memberName)
        {
            if (target == null) throw new Exception($"Cannot access member '{memberName}' on null");
            
            Type type = target as Type;
            object instance = target;
            BindingFlags flags = BindingFlags.Public | BindingFlags.NonPublic;

            if (type != null)
            {
                flags |= BindingFlags.Static;
                instance = null;
                if (TryGetMember(type, null, memberName, flags, out object result)) return result;

                flags = BindingFlags.Public | BindingFlags.Instance;
                instance = type;
                type = typeof(Type);
            }
            else
            {
                type = target.GetType();
                flags |= BindingFlags.Instance;
            }

            if (TryGetMember(type, instance, memberName, flags, out object res)) return res;

            throw new Exception($"Member '{memberName}' not found on type '{type.FullName}'");
        }
        
        private object AccessMember(Type type, object instance, string memberName)
        {
             var flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance;
             if (TryGetMember(type, instance, memberName, flags, out object res)) return res;
             throw new Exception($"Member '{memberName}' not found on type '{type.FullName}'");
        }

        private bool TryGetMember(Type type, object instance, string memberName, BindingFlags flags, out object result)
        {
            var prop = type.GetProperty(memberName, flags);
            if (prop != null) 
            {
                result = prop.GetValue(instance);
                return true;
            }

            var field = type.GetField(memberName, flags);
            if (field != null) 
            {
                result = field.GetValue(instance);
                return true;
            }
            
            result = null;
            return false;
        }

        private object AccessIndexer(object target, object[] args)
        {
            if (target == null) throw new Exception("Cannot index null");
            
            if (target is Array arr && args.Length == 1 && args[0] is int idx)
            {
                return arr.GetValue(idx);
            }
            
            if (target is IList list && args.Length == 1 && args[0] is int listIdx)
            {
                return list[listIdx];
            }

            Type type = target.GetType();
            PropertyInfo indexer = null;
            
            foreach (var prop in type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic))
            {
                if (prop.GetIndexParameters().Length == args.Length)
                {
                    indexer = prop;
                    if (prop.Name == "Item") break;
                }
            }

            if (indexer != null)
            {
                var parameters = indexer.GetIndexParameters();
                object[] convertedArgs = new object[args.Length];
                for(int i=0; i<args.Length; i++)
                {
                    convertedArgs[i] = ConvertArg(args[i], parameters[i].ParameterType);
                }
                return indexer.GetValue(target, convertedArgs);
            }

            throw new Exception($"No suitable indexer found on type '{type.Name}'");
        }

        private object InvokeMethodOnTarget(object target, string methodName, object[] args)
        {
            Type type = target as Type;
            object instance = target;
            BindingFlags flags = BindingFlags.Public | BindingFlags.NonPublic;

            if (type != null)
            {
                flags |= BindingFlags.Static;
                instance = null;
            }
            else
            {
                type = target.GetType();
                flags |= BindingFlags.Instance;
            }
            
            return InvokeMethodOnTarget(type, instance, methodName, args);
        }

        private object InvokeMethodOnTarget(Type type, object instance, string methodName, object[] args)
        {
            var flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance;
            
            var methods = type.GetMethods(flags).Where(m => m.Name == methodName && m.GetParameters().Length == args.Length).ToList();
            
            if (methods.Count == 0) throw new Exception($"Method '{methodName}' not found on type '{type.Name}' with {args.Length} arguments");
            
            MethodInfo method = methods.First(); 
            
            var parameters = method.GetParameters();
            object[] convertedArgs = new object[args.Length];
            for(int i=0; i<args.Length; i++)
            {
                convertedArgs[i] = ConvertArg(args[i], parameters[i].ParameterType);
            }
            
            return method.Invoke(instance, convertedArgs);
        }

        private object ConvertArg(object arg, Type targetType)
        {
            if (arg == null) return null;
            if (targetType.IsAssignableFrom(arg.GetType())) return arg;
            return Convert.ChangeType(arg, targetType);
        }
    }
}
