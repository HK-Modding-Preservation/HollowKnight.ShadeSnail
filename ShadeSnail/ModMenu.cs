using Satchel.BetterMenus;
using System;

namespace ShadeSnail
{
    public static class ModMenu
    {
        private static Menu menu;
        private static MenuScreen menuScreen;

        /// <summary>
        /// Builds the Exaltation Expanded menu
        /// </summary>
        /// <param name="modListMenu"></param>
        /// <returns></returns>
        public static MenuScreen CreateMenuScreen(MenuScreen modListMenu)
        {
            // Declare the menu
            menu = new Menu("Shade Snail Options", new Element[] { });

            // Populate main menu
            menu.AddElement(new HorizontalOption("Spawn Shade?",
                                                   "",
                                                   MenuValues(),
                                                   value => ShadeSnail.globalSettings.spawnShade = Convert.ToBoolean(value),
                                                   () => Convert.ToInt32(ShadeSnail.globalSettings.spawnShade)));
            menu.AddElement(new HorizontalOption("Allow Spells?",
                                                   "Shade can use spells",
                                                   MenuValues(),
                                                   value => ShadeSnail.globalSettings.allowSpells = Convert.ToBoolean(value),
                                                   () => Convert.ToInt32(ShadeSnail.globalSettings.allowSpells)));
            menu.AddElement(new HorizontalOption("One-Hit KO?",
                                                   "Shade kills instantly",
                                                   MenuValues(),
                                                   value => ShadeSnail.globalSettings.fatalShade = Convert.ToBoolean(value),
                                                   () => Convert.ToInt32(ShadeSnail.globalSettings.fatalShade)));

            // Insert the menu into the overall menu
            menuScreen = menu.GetMenuScreen(modListMenu);

            return menuScreen;
        }

        private static string[] MenuValues()
        {
            return new string[] { "NO", "YES" };
        }
    }
}
