﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace XUnity.AutoTranslator.Plugin.Core.UI
{
   internal static class GUIUtil
   {
      public const float WindowTitleClearance = 10;
      public const float ComponentSpacing = 10;
      public const float HalfComponentSpacing = ComponentSpacing / 2;
      public const float LabelWidth = 60;
      public const float LabelHeight = 21;
      public const float RowHeight = 21;

      public static readonly RectOffset Empty = new RectOffset( 0, 0, 0, 0 );

      public static readonly GUIStyle LabelTranslation = new GUIStyle( GUI.skin.label )
      {
         richText = false,
         margin = new RectOffset( GUI.skin.label.margin.left, GUI.skin.label.margin.right, 0, 0 ),
         padding = new RectOffset( GUI.skin.label.padding.left, GUI.skin.label.padding.right, 0, 0 )
      };

      public static readonly GUIStyle LabelCenter = new GUIStyle( GUI.skin.label )
      {
         alignment = TextAnchor.UpperCenter,
         richText = true
      };

      public static readonly GUIStyle LabelRight = new GUIStyle( GUI.skin.label )
      {
         alignment = TextAnchor.UpperRight
      };

      public static readonly GUIStyle LabelRich = new GUIStyle( GUI.skin.label )
      {
         richText = true
      };

      public static readonly GUIStyle NoMarginButtonStyle = new GUIStyle( GUI.skin.button ) { margin = Empty };

      public static readonly GUIStyle NoMarginButtonPressedStyle = new GUIStyle( GUI.skin.button )
      {
         margin = Empty,
         onNormal = GUI.skin.button.onActive,
         onFocused = GUI.skin.button.onActive,
         onHover = GUI.skin.button.onActive,
         normal = GUI.skin.button.onActive,
         focused = GUI.skin.button.onActive,
         hover = GUI.skin.button.onActive,
      };

      public static readonly GUIStyle NoSpacingBoxStyle = new GUIStyle( GUI.skin.box )
      {
         margin = Empty,
         padding = Empty
      };

      public static GUIStyle WindowBackgroundStyle = new GUIStyle
      {
         normal = new GUIStyleState
         {
            background = CreateBackgroundTexture()
         }
      };

      public static Rect R( float x, float y, float width, float height ) => new Rect( x, y, width, height );

      private static Texture2D CreateBackgroundTexture()
      {
         var windowBackground = new Texture2D( 1, 1, TextureFormat.ARGB32, false );
         windowBackground.SetPixel( 0, 0, new Color( 0.6f, 0.6f, 0.6f, 1 ) );
         windowBackground.Apply();
         GameObject.DontDestroyOnLoad( windowBackground );
         return windowBackground;
      }

      public static GUIStyle GetWindowBackgroundStyle()
      {
         if( !WindowBackgroundStyle.normal.background )
         {
            WindowBackgroundStyle = new GUIStyle
            {
               normal = new GUIStyleState
               {
                  background = CreateBackgroundTexture()
               }
            };
         }

         return WindowBackgroundStyle;
      }

      public static bool IsAnyMouseButtonOrScrollWheelDown
      {
         get
         {
            return Input.mouseScrollDelta.y != 0f
               || Input.GetMouseButtonDown( 0 )
               || Input.GetMouseButtonDown( 1 )
               || Input.GetMouseButtonDown( 2 );
         }
      }

      public static bool IsAnyMouseButtonOrScrollWheel
      {
         get
         {
            return Input.mouseScrollDelta.y != 0f
               || Input.GetMouseButton( 0 )
               || Input.GetMouseButton( 1 )
               || Input.GetMouseButton( 2 );
         }
      }
   }
}
