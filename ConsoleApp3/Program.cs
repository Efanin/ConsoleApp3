using ConsoleApp3;

Enemy enemy = new Enemy();
enemy.state();
Player player = new Player("Igor");
player.state();
Hero rabbit = new Hero("rabbit", 1, 100);
rabbit.state();

player.takeItem(new Item("Sword", 2), new Item("Knife", 1), new Item("Knife", 2));
player.inventory();
player.dropItem("Knife");
player.inventory();

Fight.Start(player, enemy);

player.FirstAID();
enemy.FirstAID();
rabbit.FirstAID();
enemy.state();
player.state();
rabbit.state();