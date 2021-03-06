﻿### 3.5.0
 * FEATURE - Harmony 2.0-prerelease support (in order to support BepInEx 5.0.0-RC1)
 * BUG FIX - Fixed a bug where the plugin would sometimes dump textures if 'DetectDuplicateTextureNames' was turned on, even though 'EnableTextureDumping' was turned off
 * BUG FIX - Correct whitespace handling of source languages requiring whitelines between words

### 3.4.0
 * FEATURE - Added capability of plugin to detect textures that shares the same resource name and identify these resources in an alternative way
 * BUG FIX - Fixed an issue with TextMeshPro that could cause text to glitch in certain situations

### 3.3.1
 * MISC - Options to cache results of regex lookups and whitespace differences
 * BUG FIX - Fixed 'WhitespaceRemovalStrategy.TrimPerNewline' which was broken to remove all non-repeating whitespace, rather than only the non-repeating whitespace surrounding newlines
 * BUG FIX - Fully clear translations before reloading (ALT+R)

### 3.3.0
 * FEATURE - Support 'TARC' regex formatting in translation files
 * FEATURE - Much improved handling of whitespace and newlines. Option 'TrimAllText' removed and options for 'WhitespaceRemovalStrategy' changed
 * BUG FIX - Allow hooking of text with components named 'Dummy'

### 3.2.0
 * FEATURE - BepInEx 5.x plugin support
 * CHANGE - Restructured large portions of the internal code to support more features going forward
 * BUG FIX - Interacting with UI now blocks input to game
 * BUG FIX - Better handling of error'ed translations in relation to rich text
 * BUG FIX - Minor fixes to 'copy to clipboard' to disable IMGUI spam
 * BUG FIX - Fixed potential NullReferenceException in GoogleTranslate and BingTranslate during timeout errors
 * MISC - Removed 'Dump Untranslated Texts' hotkey due to feature bloat
 * MISC - Allow unselecting translation endpoint in UI
 * MISC - Increased request timeout from 50 to 150 seconds to ensure better error logging of failed requests

### 3.1.0
 * FEATURE - Support for games with 'netstandard2.0' API surface through config option 'EnableExperimentalHooks'
 * BUG FIX - Bug fixes and improvements to Utage hooking implementation - EnableUtage config option also removed (always on now)
 * BUG FIX - Rich text parser bug fixes when only a single tag with no ending was used
 * BUG FIX - Fixed potential NullReferenceException in TextGetterCompatibilityMode
 * BUG FIX - Load translator assemblies even if a '#' is present in file path
 * MISC - Determine whether to disable certificate checks at config initialization based on scripting backend and unity version

### 3.0.2
 * BUG FIX - UnityInjector installer package now uses correct folder structure (Translators has been moved into Config folder) and ExIni is no longer distributed
 * BUG FIX - Fixed harmony priority usage, which was incorrectly used in 3.0.1
 * MISC - Plugin should no longer translate text input fields for NGUI
 * MISC - Added config option to 'DisableCertificateValidation' for all hosts under all circumstances in case the plugin locks up. This option is only required by very few games
 * MISC - Experimental hooking support for methods with no body (configured through 'EnableExperimentalHooks' setting)
 * MISC - Restructured README file. New order: 1. Installation, 2. Usage, 3. Configuration, 4. Integration 

### 3.0.1
 * BUG FIX - Fixed bug that could in certain situation cause IMGUI translation to drain on performance
 * BUG FIX - Never close a service point while a request is ongoing. Previously this could cause the plugin to lockup
 * BUG FIX - Only disable certificate checks if the .NET version is at or below 3.5
 * BUG FIX - Improved cleanup of object references
 * BUG FIX - Improved 'text stagger' check. Sometimes the plugin was identifying text as scrolling in, even though it was not
 * MISC - Proper test and support for .NET 4.x equivalent scripting backend for Unity
 * MISC - Timeout handling if an endpoint becomes unresponsive
 * MISC - Support post processing for normal text translations
 * MISC - Change harmony text hook priority to 'Last' instead of simply be executed 'after DTL'
 * MISC - More resilient harmony hook implementation to support potentially different versions of harmony being used
 * MISC - Updated harmony version deployed with the plugin (for IPA, ReiPatcher and UnityInjector), so it is no longer the homebrew version that was distributed with BepInEx
 * MISC - Made UI more readable by using a solid background
 * MISC - Changed max queued translations from 3500 to 4000

### 3.0.0
 * FEATURE - UI to control plugin more conveniently (press ALT + 0 (that's a zero))
 * FEATURE - Dynamic selection of translator during game session
 * FEATURE - Support BingTranslate API
 * FEATURE - Support LEC Offline Power Translator 15
 * FEATURE - Enable custom implementations of translators
 * FEATURE - Removed support for Excite translate because it only support the 'WWW' API in Unity due to missing Tls1.2 support
 * FEATURE - Updated Watson translate to v3
 * FEATURE - Support for 'romaji' as output language. Only google supports this at the moment
 * FEATURE - Batching support for all endpoints where the API supports it
 * BUG FIX - Too many small fixes to mention
 * MISC - {GameExeName} variable can now be used in configuration of directories and files
 * MISC - Changed the way the 'Custom' endpoint works. See README for more info
 * MISC - Added new configuration 'GameLogTextPaths' to enable special handling of text components that text is being appended to continuously (requires export knowledge to setup)

### 2.18.0
 * FEATURE - Text Getter Compatibility Mode. Fools the game into thinking that it is not actually translated
 * FEATURE - Textures - Live2D component support
 * FEATURE - Textures - SpriteRenderer component support
 * FEATURE - Hotkey to reboot plugin in certain situations
 * BUG FIX - No longer trim translated text (if configured) when loading translation files
 * MISC - Support legacy OnLevelWasLoaded
 * MISC - Avoid harmless 'log errors' in relation to texture translation
 * MISC - Set max value of MaxCharactersPerTranslation to 500
 * MISC - Documentation update to describe 'Behaviour' configuration section
 * MISC - Removed "FromImageNameThenData" as hash source on textures
 * MISC - Added "FromImageNameAndScene" as hash source on textures
 * MISC - Inline comment handling when using '//' to indicate a comment
 * MISC - Improved default configuration for Utage-related games to improve translation when newlines are involved

### 2.17.0
 * FEATURE - Support legitimate Bing translate API (requires key)
 * FEATURE - Documented custom endpoint
 * BUG FIX - Fixed bug in older versions of the Unity engine where the plugin would crash on startup due to missing APIs in relation to the SceneManagement namespace
 * BUG FIX - Fixed bug that could happen in Utage-based games, that would cause dialogue to sometimes be cut off mid-sentence
 * BUG FIX - Incorrect handling of 'null' default values in configuration
 * BUG FIX - Various other minor fixes
 * MISC - Added configuration option to support ignoring texts starting with certain characters, IgnoreTextStartingWith
 * MISC - Template reparation for IMGUI translations
 * MISC - Big update to README file to fully describe the features of the plugin

### 2.16.0
 * FEATURE - Support image dumping and loading (not automatic!). Disabled by default
 * BUG FIX - Fixed toggle translation which was broken in 2.15.4
 * BUG FIX - Updated TKK retrieval logic
 * MISC - Removed Jurassic dependency as it is no longer required

### 2.15.4
 * MISC - Added configuration option to apply 'UI resize behaviour' to all components regardless of them being translated: ForceUIResizing
 * MISC - Added configuration option to change line spacing for UGUI within the 'UI resize behaviour': ResizeUILineSpacingScale

### 2.15.3
 * BUG FIX - Potential crash during startup where potentially 'illegal' property was being read.
 * MISC - Support 'scrolling text' for immediate components such as IMGUI. Previously such behaviour would shut down the plugin.
 * MISC - Changed behaviour of font overriding. All found Text instances will now have their fonts changed.

### 2.15.2
 * BUG FIX - Fixed bug that could cause hooking not to work when hooks were overriden by external plugin

### 2.15.1
 * BUG FIX - Updated TKK retrieval logic. Improved error message if it cannot be retrieved.

### 2.15.0
 * FEATURE - Manual hooking - press ALT + U. This will lookup all game objects and attempt translation immediately
 * FEATURE - Capability for other plugins to tell the Auto Translator not to translate texts
 * BUG FIX - Initialization hooking that will attempt to hook any game object that was missed during game initialization
 * BUG FIX - Minor fixes to handling of rich text to better support tags that should be ignored, such as ruby, group
 * MISC - Generally better hooking capabilities

### 2.14.1
 * BUG FIX - Never allow text to be queued for translation before stabilization check for rich text 
 * MISC - Improved a spam detection check

### 2.14.0
 * FEATURE - Dramatically improved the text hooking capability for NGUI to much better handle static elements

### 2.13.1
 * BUG FIX - Minor bug fix in rich text parser
 * MISC - Enable Rich Text for TextMeshPro
 * MISC - Improved whitespace handling with additional configuration option

### 2.13.0
 * FEATURE - Support for older Unity Engine versions
 * BUG FIX - Respect BepInEx logger config over own config
 * BUG FIX - Fix exception that could occur in relation to NGUI
 * MISC - Less leniency in what constitutes an error when translating

### 2.12.0
 * FEATURE - General support for rich text in relation to UGUI and Utage
 * FEATURE - Experimental support for custom fonts for UGUI
 * CHANGE - Support only source languages with predefined character checks - for now (ja, zh-CN, zh-TW, ru, ko, en)
 * CHANGE - Slightly different translation load priority from files
 * BUG FIX - Dramatically improved resize behaviour for NGUI
 * BUG FIX - Fixed a bug where hook overrides would not always be honored depending on mod load order
 * MISC - 3 additional spam prevention checks
 * MISC - Uses BepInLogger for BepInEx implementation (requires 4.0.0+)
 * MISC - Redirect "GoogleTranslateHack" to "GoogleTranslate" because instructions were being distributed to use this, and it is not very friendly towards their APIs

### 2.11.0
 * FEATURE - Support for legitimate Google Cloud Translate API (requires key)
 * BUG FIX - Fixed situations where a text would not be translated on a component if a operation is ongoing on the component
 * BUG FIX - Less delay on translation in certain situations
 * MISC - Plugin seeded with ~10000 manually translated texts for commonly used translations to avoid hitting the configured endpoint too much (enable or disable with "UseStaticTranslations")
   * Only applies when configured for Japanese to English (default)

### 2.10.1
 * BUG FIX - Fix to prevent text overflow for large component for UGUI

### 2.10.0
 * FEATURE - Support Yandex translate (requires key)
 * FEATURE - Support Watson translate (requires key)
 * FEATURE - Batching support for selected endpoints (makes translations much faster and requires lesser request)
 * FEATURE - Experimental Utage support
 * BUG FIX - Fixed minor bug during reading of text translation cache
 * BUG FIX - Now escapes the '='-sign in the translation file, so texts containing this character can be translated
 * BUG FIX - Fixed kana check when testing if a text is a candidate for translation
 * MISC - No longer creating a new thread for each translation
 * MISC - Proactive closing of unused TCP connections
 * CONFIG - TrimAllText, to indicate whether whitespace in front of and behind translation candidates should be removed
 * CONFIG - EnableBatching, to indicate whether batching should be enabled for supported endpoints
 * CONFIG - EnableUIResizing, to indicate whether the plugin should make a "best attempt" at resizing the UI upon translation. Current only work for NGUI

### 2.9.1
 * MISC - Added automatic configuration migration support
   * Versions of this plugin were being distributed with predefined configuration to target "GoogleTranslateHack". The first time the plugin is run under this version, it will change this value back to the default.

### 2.9.0
 * FEATURE - Installation as UnityInjector plugin
 * FEATURE - Support Excite translate
 * MISC - Better debugging capabilities with extra config options

### 2.8.0
 * CHANGE - Whether SSL is enabled or not is now entirely based on chosen endpoint support
 * FEATURE - Support for IMGUI translation texts with numbers
 * FEATURE - Support for overwriting IMGUI hook events
 * BUG FIX - Improved fix for gtrans (23.07.2018) by supporting persistent HTTP connections and cookies and recalculation of TKK and SSL
 * BUG FIX - Fixed whitespace handling to honor configuration more appropriately
 * BUG FIX - User-interaction (hotkeys) now works when in shutdown mode
 * MISC - Prints out to console errors that occurrs during translation
 * MISC - IMGUI is still disabled by default. Often other mods UI are implemented in IMGUI. Enabling it will allow those UIs to be translated as well. 
   * Simply change the config, such that: EnableIMGUI=True

### 2.7.0
 * FEATURE - Additional installation instructions for standalone installation through ReiPatcher
 * BUG FIX - Fixed a bug with NGUI that caused those texts not to be translated
 * BUG FIX - Improved fix for gtrans (23.07.2018)

### 2.6.0
 * FEATURE - Support for newer versions of unity engine (those including UnityEngine.CoreModule, etc. in Managed folder)
 * BUG FIX - Fix for current issue with gtrans (23.07.2018)
 * BUG FIX - Keeps functioning if web services fails, but no requests will be sent in such scenario. Texts will simply be translated from cache
 * BUG FIX - Changed hooking, such that if text framework fails, the others wont also fail
 * MISC - Concurrency now based on which type of endpoint. For gtrans it is set to 1
 * MISC - Bit more leniency in translation queue spam detection to prevent shutdown of plugin under normal circumstances

### 2.5.0
 * FEATURE Copy to clipboard feature
 * BUG FIX - Various new rate limiting patterns to prevent spam to configured translate endpoint

### 2.4.1
 * BUG FIX - Disabled IMGUI hook due to bug

### 2.4.0
 * CHANGE - Completely reworked configuration for more organization
 * FEATURE - Added support for BaiduTranslate. User must provide AppId/AppSecret for API . Use "BaiduTranslate" as endpoint
 * FEATURE - Force splitting translated texts into newlines, if configured
 * BUG FIX - Fixed broken feature that allowed disabling the online Endpoint
 * BUG FIX - Eliminated potential concurrency issues that could cause a translated string to be retranslated.
 * BUG FIX - Better support for other 'from' languages than japanese, as the japanese symbol check has been replaced with a more generic one
 * BUG FIX - Fixed a bug where hot key actions (toggle translation, etc.) would often fail
 * BUG FIX - Multiline translations now partially supported. However, all texts considered dialogue will still be translated as a single line
 * BUG FIX - More leniency in allowing text formats (in translation files) to be included as translations

### 2.3.1
 * BUG FIX - Fixed bug that caused the application to quit if any hooks were overriden.

### 2.3.0
 * FEATURE - Allow usage of SSL
 * BUG FIX - Better dialogue caching handling. Often a dialogue might get translated multiple times because of small differences in the source text in regards to whitespace.

### 2.2.0
 * MISC - Added anti-spam safeguards to web requests that are sent. What it means: The plugin will no longer be able to attempt to translate a text it already considers translated.
 * MISC - Changed internal programmatic HTTP service provider from .NET WebClient to Unity WWW.

### 2.1.0
 * FEATURE - Added configuration options to control which text frameworks to translate
 * FEATURE - Added integration feature that allows other translation plugins to use this plugin as a fallback
 * BUG FIX - Fixed a bug that could cause a StackOverflowException in unfortunate scenarios, if other mods interfered.
 * BUG FIX - MUCH improved dialogue handling. Translations for dialogues should be significantly better than 2.0.1

### 2.0.1
 * BUG FIX - Changed configuration path so to not conflict with the configuration files that other mods uses, as it does not use the shared configuration system. The previous version could override configuration from other mods.
 * MISC - General performance improvements.

### 2.0.0
 * Initial release
