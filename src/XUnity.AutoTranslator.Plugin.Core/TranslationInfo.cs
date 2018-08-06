﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace XUnity.AutoTranslator.Plugin.Core
{
   public class TranslationInfo
   {
      private static readonly string MultiLinePropertyName = "multiLine";
      private static readonly string OverflowMethodPropertyName = "overflowMethod";
      private static readonly string UILabelClassName = "UILabel";

      private Action<object> _reset;

      public TranslationInfo()
      {
      }

      public string OriginalText { get; set; }

      public string TranslatedText { get; set; }

      public bool IsTranslated { get; set; }

      public bool IsAwake { get; set; }

      public bool IsCurrentlySettingText { get; set; }

      public void ResizeUI( object graphic )
      {
         if( graphic == null ) return;

         var type = graphic.GetType();

         // special handling for NGUI to better handle textbox sizing
         if( type.Name == UILabelClassName )
         {
            var originalMultiLine = type.GetProperty( MultiLinePropertyName )?.GetGetMethod()?.Invoke( graphic, null );
            var originalOverflowMethod = type.GetProperty( OverflowMethodPropertyName )?.GetGetMethod()?.Invoke( graphic, null );

            type.GetProperty( MultiLinePropertyName )?.GetSetMethod()?.Invoke( graphic, new object[] { true } );
            type.GetProperty( OverflowMethodPropertyName )?.GetSetMethod()?.Invoke( graphic, new object[] { 0 } );

            _reset = g =>
            {
               var gtype = g.GetType();
               gtype.GetProperty( MultiLinePropertyName )?.GetSetMethod()?.Invoke( g, new object[] { originalMultiLine } );
               gtype.GetProperty( OverflowMethodPropertyName )?.GetSetMethod()?.Invoke( g, new object[] { originalOverflowMethod } );
            };
         }
      }

      public void UnresizeUI( object graphic )
      {
         if( graphic == null ) return;

         _reset?.Invoke( graphic );
         _reset = null;
      }

      public TranslationInfo Reset( string newText )
      {
         IsTranslated = false;
         TranslatedText = null;
         OriginalText = newText;

         return this;
      }

      public void SetTranslatedText( string translatedText )
      {
         IsTranslated = true;
         TranslatedText = translatedText;
      }
   }
}
