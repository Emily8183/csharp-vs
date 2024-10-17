// See https://aka.ms/new-console-template for more information

using Chapter4and5;

MenuItem menuitem1 = new MenuItem("burger", 13, "Vegan", "main");
MenuItem menuitem2 = new MenuItem("cookie", 3, "yum", "dessert");
MenuItem menuitem3 = new MenuItem("ice cream", 5, "sweet", "dessert");
MenuItem menuitem4 = new MenuItem("ice cream", 5, "sweet", "dessert");

//Console.WriteLine(menuitem1.Name);
//can directly print out in this way

//Console.WriteLine(menuitem1);
//added override ToString to print out this object from the MenuItem class

Menu menu = new Menu();

menu.AddItem(menuitem1);
menu.AddItem(menuitem2);
menu.AddItem(menuitem3);
menu.AddItem(menuitem4);

menu.RemoveItem(menuitem2);

Console.WriteLine(menu);

// Test IsNew() on one of the items
Console.WriteLine(menuitem3.IsNew());

//create a new menu
//Menu menu2 = new Menu();

//MenuItem menuitem4 = new MenuItem("milk",5,"fresh","diary");
//MenuItem menuitem5 = new MenuItem("milk", 6, "fresh", "diary");

//menu2.AddItem(menuitem4);
////menu2.AddItems(menuitem5);

//Console.WriteLine(Equals(menu, menu2));

//Console.WriteLine(menu);

