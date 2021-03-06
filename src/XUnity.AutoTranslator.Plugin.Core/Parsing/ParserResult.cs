﻿using System.Collections.Generic;

namespace XUnity.AutoTranslator.Plugin.Core.Parsing
{
   internal class ParserResult
   {
      public ParserResult( string originalText, string template, bool succeeded, bool persistCombinedResult, Dictionary<string, string> args )
      {
         OriginalText = originalText;
         Template = template;
         Succeeded = succeeded;
         PersistCombinedResult = persistCombinedResult;
         Arguments = args;
      }

      public string OriginalText { get; private set; }

      public string Template { get; private set; }

      public Dictionary<string, string> Arguments { get; private set; }

      public bool Succeeded { get; private set; }

      public bool PersistCombinedResult { get; private set; }

      public string Untemplate( Dictionary<string, string> arguments )
      {
         string result = Template;
         foreach( var kvp in arguments )
         {
            result = result.Replace( kvp.Key, kvp.Value );
         }
         return result;
      }
   }
}
