﻿using System;
using System.Linq;
using System.Text;
using XUnity.AutoTranslator.Plugin.Core.Constants;

namespace XUnity.AutoTranslator.Plugin.Core
{
   /// <summary>
   /// Class that allows you to check which features are availble of the Unity version that is used.
   /// </summary>
   public static class Features
   {
      internal static bool SupportsClipboard { get; } = false;

      /// <summary>
      /// Gets a bool indicating if the class CustomYieldInstruction is available.
      /// </summary>
      public static bool SupportsCustomYieldInstruction { get; } = false;

      /// <summary>
      /// Gets a bool indicating if the SceneManager class is available.
      /// </summary>
      public static bool SupportsSceneManager { get; } = false;

      /// <summary>
      /// Gets a bool indicating if this game is running in a .NET 4.x runtime.
      /// </summary>
      public static bool SupportsNet4x { get; } = false;

      static Features()
      {
         try
         {
            SupportsClipboard = ClrTypes.TextEditor?.GetProperty( "text" )?.GetSetMethod() != null;
         }
         catch( Exception )
         {
            
         }

         try
         {
            SupportsCustomYieldInstruction = ClrTypes.CustomYieldInstruction != null;
         }
         catch( Exception )
         {
            
         }

         try
         {
            SupportsSceneManager = ClrTypes.Scene != null && ClrTypes.SceneManager != null;
         }
         catch( Exception )
         {

         }

         try
         {
            SupportsNet4x = ClrTypes.Task != null;
         }
         catch( Exception )
         {

         }
      }
   }
}
