// See https://aka.ms/new-console-template for more information

using Chapter4and5;

MenuItem menuitem1 = new MenuItem("burger", 13, "Vegan", "main");
MenuItem menuitem2 = new MenuItem("cookie", 3, "yum", "dessert");
MenuItem menuitem3 = new MenuItem("ice cream", 5, "sweet", "dessert");

//Console.WriteLine(menuitem1.Name);
//can directly print out in this way

//Console.WriteLine(menuitem1);
//added override ToString to print out this object from the MenuItem class

Menu menu = new Menu();

menu.AddItems(menuitem1);
menu.AddItems(menuitem2);
menu.AddItems(menuitem3);

Console.WriteLine(menu);
