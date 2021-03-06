﻿using XUnity.AutoTranslator.Plugin.Core.Configuration;

namespace XUnity.AutoTranslator.Plugin.Core
{
   /// <summary>
   /// Class representing publicly available settings of the plugin.
   /// </summary>
   public static class AutoTranslatorSettings
   {
      /// <summary>
      /// Gets the user-supplied user agent.
      /// </summary>
      public static string UserAgent => Settings.UserAgent;

      /// <summary>
      /// Gets the configured source language.
      /// </summary>
      public static string SourceLanguage => Settings.FromLanguage;

      /// <summary>
      /// Gets the configured destination language.
      /// </summary>
      public static string DestinationLanguage => Settings.Language;
   }
}
