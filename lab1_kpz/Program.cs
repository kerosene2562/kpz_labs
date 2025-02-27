using lab1_kpz.classes;

Product baklazan = new Product("баклажан", new Money("UAH", 100, 50), "найкращий баклажани", "кг", 70, DateTime.Now);
Product banan = new Product("банан", new Money("USD", 77, 10), "топ банани", "кг", 100, DateTime.Now);
Warehouse sklad1 = new Warehouse();
sklad1.getReporting().addProduct(baklazan);
sklad1.getReporting().addProduct(banan);
sklad1.getReporting().getAllProducts();

sklad1.getReporting().decreaseProduct(banan, 10);
sklad1.getReporting().getAllProducts();

sklad1.getReporting().decreasePriceOnProduct(baklazan, new Money("UAH", 10, 50));