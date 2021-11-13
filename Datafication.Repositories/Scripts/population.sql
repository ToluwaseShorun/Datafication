-- Populate manufacturers
INSERT INTO Manufacturers (Name, Bio, ExternalUrl, CreatedDate, ModifiedDate) VALUES('General Mills', 'Manufacturer of food products for industrial applications. Products include cereals, dough, pastries, ice cream, meal, pasta, pizza and snacks. Soup, spices, vegetables, yogurt and pet food also offered.', 'https://www.generalmills.com/', getdate(), getdate());

INSERT INTO Manufacturers (Name, Bio, ExternalUrl, CreatedDate, ModifiedDate) VALUES('Unilever', 'Unilever is the largest producer of ice cream across the globe with a workforce of 149,000 employees. With presence in 54 countries, the company sells its products in over 190 countries under the umbrella of over 400 brand names. Amongst these, Unilever mainly markets its ice creams under the branch of Heartbrand, which includes numerous brands with a ‘heart’-similar logo. Some of these brands include Good Humor, Aligda Ice Cream, Kwality Wall’s Ice Cream, Bresler, Cargills, Eskimo, Lusso, and Miko. Besides this, the company sells ice cream under other brand names, such as Popsicle, Talenti Gelato, Ben and Jerry’s, Breyers, and Klondike.', 'https://www.unilever.com/', getdate(), getdate());

INSERT INTO Manufacturers (Name, Bio, ExternalUrl, CreatedDate, ModifiedDate) VALUES('Ben & Jerry''s', 'From a renovated gas station in Burlington, Vermont, to far-off places with names we sometimes mispronounce, the journey that began in 1978 with 2 guys and the ice cream business they built is as legendary as the ice cream is euphoric.', 'https://www.benjerry.com/', getdate(), getdate());

-- Populate ice creams
INSERT INTO IceCreams (Name, Description, ManufacturerId, CreatedDate, ModifiedDate) VALUES('Häagen-Dazs - Amaretto Black Cherry Almond Toffee Non-Dairy', 'Rich black cherry jam and sweet almond toffee pieces are folded into our non-dairy dessert that’s infused with a nutty Amaretto.', 1, getdate(), getdate());
INSERT INTO IceCreams (Name, Description, ManufacturerId, CreatedDate, ModifiedDate) VALUES('Häagen-Dazs - Banana Peanut Butter Chip Ice Cream', 'Ribbons of rich peanut butter and bits of chocolate chips are folded into sweet banana ice cream to create this playfully indulgent flavor.', 1, getdate(), getdate());
INSERT INTO IceCreams (Name, Description, ManufacturerId, CreatedDate, ModifiedDate) VALUES('Häagen-Dazs - Bourbon Praline Pecan Ice Cream', 'Treat yourself to ice cream infused with smooth Bourbon sprinkled with brown sugar and given the perfect crunch with praline pecans.', 1, getdate(), getdate());
INSERT INTO IceCreams (Name, Description, ManufacturerId, CreatedDate, ModifiedDate) VALUES('Häagen-Dazs - Caramel Cone Ice Cream Bar', 'Your favorite Caramel Pizzelle Bar, renamed. Golden ribbons of caramel in creamy vanilla gelato, enrobed in rich milk chocolate and crunchy italian style cone pieces.', 1, getdate(), getdate());

INSERT INTO IceCreams (Name, Description, ManufacturerId, CreatedDate, ModifiedDate) VALUES('Magnum - Mini Ice Cream Treat Variety Pack - Classic, Almond, & White', 'The Magnum ice cream Mini Variety is a collection of three of your favorite Magnum ice cream flavors — Magnum Classic, Mangum Almond and Magnum White Chocolate. Made with Belgian chocolate, each of these creamy and fragrant vanilla ice cream bars is dipped in a different decadent and rich chocolate coating. The Magnum Mini Classic is dipped in 44% milk chocolate cacao, the Mini Almond is dipped in 39% cacao milk chocolate and topped crunchy sea salt roasted almonds, and the Mini White Chocolate is dipped in 33% cacao white chocolate. With their perfectly snackable size and only 140-150 calories per bar, these Magnum ice cream bars are sure to satisfy each and every one of your chocolate cravings. Discover the ultimate treat for Magnum Mini ice cream lovers! Whether you love the classic milk chocolate ice cream bar, the savory sweet almond bar or the sweet decadence of the white chocolate ice cream bar, there’s a decadent, but mini ice cream treat in this variety box for you. All made with Magnum chocolate’s deliciously creamy vanilla ice cream, these mini ice cream bars are crafted with high quality ingredients, chosen by Magnum ice cream chocolatiers. With their perfect small ice cream size, these Magnum Minis are a delightfully tiny indulgence. To purchase these chocolate ice cream bars and other Magnum flavors, check out our store locator in the links below.', 2, getdate(), getdate());
INSERT INTO IceCreams (Name, Description, ManufacturerId, CreatedDate, ModifiedDate) VALUES('Magnum - Double Raspberry Ice Cream Bar', 'Experience berry bliss with a double chocolate twist. Delectable Magnum ice cream Double Raspberry ice cream Bars are a luxurious treat crafted with wild raspberry ice cream, dipped in a gooey chocolate layer and delightfully tart raspberry sauce, and covered again in a 44% cacao milk chocolate shell. Made with Belgian chocolate, this chocolate raspberry ice cream bar is created by Magnum ice cream, the chocolatiers of ice cream. Unlike our other Magnum ice cream flavors, this ice cream bar mixes luscious raspberry with the rich Magnum chocolate you know and love. Just like a lavish tray of chocolate-covered fruit, these raspberry bars taste sweet, delightful, and oh-so indulgent. Pamper your tastebuds with the satisfying combination of tart raspberry and high-quality chocolate in just one bite of this raspberry ice cream bar. Beneath the cracking milk chocolate shell, there’s even more layers of decadence underneath. This Magnum raspberry treat satisfies your berry flavor cravings with a layer of gooey raspberry sauce, as well as its wild raspberry ice cream core. And with a double dip of rich chocolate sandwiching those sweet raspberry layers, this Magnum Chocolate ice cream bar is unique as it is indulgent. To purchase this Magnum ice cream raspberry and chocolate treat, check out the store locator in the links below.', 2, getdate(), getdate());
INSERT INTO IceCreams (Name, Description, ManufacturerId, CreatedDate, ModifiedDate) VALUES('Magnum - Double Chocolate Ice Cream Bar', 'Chocolate lovers rejoice! Magnum ice cream Double Chocolate ice cream bars are the ultimate chocolate ice cream treat. Richly indulgent chocolate ice cream is dipped in smooth chocolate fudge sauce and covered again in a 44% cacao milk chocolate shell. Made with Belgian chocolate, these luxurious chocolate ice cream bars are created by Magnum ice cream, the chocolatiers of ice cream. Designed to delight the chocolate obsessed, this Double Chocolate ice cream treat is uniquely made of four different chocolatey layers. Just bite into that cracking milk chocolate shell to discover even more chocolate decadence underneath. This isn’t a regular ice cream bar, this is a Magnum Double Chocolate ice cream bar. Satisfy every chocolate craving with just one bite of this Magnum ice cream bar. Because in just that one bite, you’ll experience two chocolate dipped layers, a gooey chocolate sauce, and a rich chocolate ice cream core. It doesn’t get much more chocolatey than this! Packed with even more chocolate than our other Magnum ice cream bars, these exceptional chocolate treats are made with only the best ingredients, chosen by the Magnum ice cream chocolatiers. So, the next time your chocolate cravings kick in, just reach for a Magnum Double Chocolate bar. To purchase this ice cream treat and other Magnum flavors, check out the store locator in the links below.', 2, getdate(), getdate());
INSERT INTO IceCreams (Name, Description, ManufacturerId, CreatedDate, ModifiedDate) VALUES('Magnum - Double Red Velvet Ice Cream Tub', 'Now you can have your cake and your ice cream, too. New Magnum ice cream Double Red Velvet Pint combines smooth cream cheese ice cream with creamy chocolate ganache sauce, white chocolate and rich red velvet cake crumbs, all enveloped in a cracking white chocolate shell. Inspired by a red velvet cake and rich cream cheese icing, and made with Belgian chocolate, this ice cream tub is the latest creation from Magnum ice cream, the chocolatiers of the ice cream aisle. It’s like we turned a decadent red velvet cake into a tub of ice cream. And what more could any red velvet cake lover ask for? Once you crack through the decadent white chocolate shell, you’ll dig into a creamy and cakey dessert that might just taste better than any slice of cake you’ve ever had. A new addition to Magnum ice cream flavors, this ice cream tub is made with cream cheese ice cream that reminds you of rich and creamy cake icing. Each ice cream spoonful is filled with swirls of rich chocolate ganache, silky white chocolate and scrumptious red velvet cake crumbs that make for a unique and luxurious combination of flavors and textures. To purchase this Magnum ice cream pint, check out the store locator in the links below.', 2, getdate(), getdate());
INSERT INTO IceCreams (Name, Description, ManufacturerId, CreatedDate, ModifiedDate) VALUES('Magnum - Dark Chocolate Mint Ice Cream Tub', 'Cool, cool, cool taste sensations. Dive into Magnum Ice Cream''s Dark Chocolate Mint Ice Cream Tubs, where rich dark chocolate and ultra-creamy minty delights merge. Dark Chocolate Mint is made up of delicious peppermint ice cream with thick pieces of dark chocolate through the pint and enveloped by a cracking shell of silky dark chocolate. Magnum Ice Cream tubs are a indulgent treat, years in the making, where delicious flavors meet unique textures. Made with real Belgian Chocolate, each spoonful is a luxurious experience. To purchase, check out our store locator in the links below:', 2, getdate(), getdate());
INSERT INTO IceCreams (Name, Description, ManufacturerId, CreatedDate, ModifiedDate) VALUES('Magnum - Double Chocolate Vanilla Truffle Ice Cream Bar', 'Double up on the delight of biting into a rich and indulgent chocolate truffle with new Magnum ice cream Double Chocolate Vanilla Truffle ice cream bars. Delightfully smooth vanilla ice cream swirled with a silky chocolate ganache is dipped in a chocolatey coating, chocolate sauce and a cracking 44% cacao milk chocolate shell. It’s decadence on decadence as layer after layer of this double chocolate ice cream bar creates a satisfying and super chocolatey bite. Inspired by our favorite chocolate truffles and made with Belgian chocolate, these vanilla ice cream bars are the newest creation from Magnum ice cream, the chocolatiers of the ice cream aisle. The secret to this chocolate truffle ice cream bar is our high-quality ingredients. From the smooth and creamy vanilla ice cream and truffle-like swirls of chocolate ganache to the satisfying crack of two layers of milk chocolate coating with a silky chocolate sauce filling in between, each layer of this chocolate and vanilla ice cream bar is delicious, magnificent and exquisitely chocolatey. It only takes one bite to fall in love with this luxurious Magnum ice cream bar. Every chocolate truffle lover will want to keep new Magnum ice cream Double Chocolate Vanilla Truffle ice cream bars in their freezer. To purchase these chocolate ice cream bars, check out the store locator in the links below.', 2, getdate(), getdate());

INSERT INTO IceCreams (Name, Description, ManufacturerId, CreatedDate, ModifiedDate) VALUES('Ben & Jerry''s - Cannoli', 'As a Limited Batch that captured the rapture of the classic Sicilian dessert, our Cannoli captivated fans like no other Cannoli could. Now that it’s a full-time flavor, you and your Cannoli can re-capture the rapture all over again.', 3, getdate(), getdate());
INSERT INTO IceCreams (Name, Description, ManufacturerId, CreatedDate, ModifiedDate) VALUES('Ben & Jerry''s - Peanut Butter Half Baked®', 'If you were more than a little bit smitten with half baked®’s peanut buttery cousin when it was a Limited Batch, we expect you could be a whole lot smittener now that it’s a full-time flavor. Enjoy!', 3, getdate(), getdate());
INSERT INTO IceCreams (Name, Description, ManufacturerId, CreatedDate, ModifiedDate) VALUES('Ben & Jerry''s - Cherry Garcia®', 'Our euphorically edible tribute to guitarist Jerry Garcia & Grateful Dead fans everywhere, it’s the first ice cream named for a rock legend and the most famous of our fan-suggested flavors.
Certified Gluten-Free.', 3, getdate(), getdate());
INSERT INTO IceCreams (Name, Description, ManufacturerId, CreatedDate, ModifiedDate) VALUES('Ben & Jerry''s - Strawberry Cheesecake', 'For strawberry cheesecake lovers who’ve always wanted to have their cheesecake and scoop it, too, we’ve created a flavor jam-packed with strawberry cheesecake-greatness and a fantastic graham-cracker swirl.', 3, getdate(), getdate());
INSERT INTO IceCreams (Name, Description, ManufacturerId, CreatedDate, ModifiedDate) VALUES('Ben & Jerry''s - The Tonight Dough®', 'Inspired by the show & host we love staying up late for, here''s a flavor you''ll love without needing a spoon for - dedicated to SeriousFun Children''s Network of global camps for kids with serious illnesses. Learn more at seriousfunnetwork.org.', 3, getdate(), getdate());

-- Populate images
INSERT INTO Images (IceCreamId, Url) VALUES(1, 'https://www.haagendazs.us/sites/site.prod1.haagendazs.us/files/product/product-image/hero-sept-2019-Sprts_AmrtoBlkChry.png');
INSERT INTO Images (IceCreamId, Url) VALUES(2, 'https://www.haagendazs.us/sites/site.prod1.haagendazs.us/files/product/product-image/hero-sept-2019-BananaPBChip.jpg');
INSERT INTO Images (IceCreamId, Url) VALUES(3, 'https://www.haagendazs.us/sites/site.prod1.haagendazs.us/files/product/product-image/hero-sept-2019-BourbonPralinePecan.png');
INSERT INTO Images (IceCreamId, Url) VALUES(4, 'https://www.haagendazs.us/sites/site.prod1.haagendazs.us/files/product/product-image/hero-sept-2019-vanilla-caramel-pizzelle-bar.jpg');

INSERT INTO Images (IceCreamId, Url) VALUES(5, 'https://www.magnumicecream.com/content/dam/unilever/magnum/united_states_of_america/pack_shot/077567369871.h-29911965-png.png.ulenscale.400x400.png');
INSERT INTO Images (IceCreamId, Url) VALUES(6, 'https://www.magnumicecream.com/content/dam/unilever/magnum/united_states_of_america/pack_shot/077567271051.h-29793319-png.png.ulenscale.400x400.png');
INSERT INTO Images (IceCreamId, Url) VALUES(7, 'https://www.magnumicecream.com/content/dam/unilever/magnum/united_states_of_america/pack_shot/077567132291.h-29910647-png.png.ulenscale.400x400.png');
INSERT INTO Images (IceCreamId, Url) VALUES(8, 'https://www.magnumicecream.com/content/dam/unilever/magnum/united_states_of_america/pack_shot/077567002396-2329517-png.png.ulenscale.400x400.png');
INSERT INTO Images (IceCreamId, Url) VALUES(9, 'https://www.magnumicecream.com/content/dam/unilever/magnum/united_states_of_america/pack_shot/077567001610-2323547-png.png.ulenscale.400x400.png');
INSERT INTO Images (IceCreamId, Url) VALUES(10, 'https://www.magnumicecream.com/content/dam/unilever/magnum/united_states_of_america/pack_shot/077567002723-2237994-png.png.ulenscale.400x400.png');

INSERT INTO Images (IceCreamId, Url) VALUES(11, 'https://www.benjerry.com/files/live/sites/systemsite/files/flavors/products/us/pint/cannoli-detail.png');
INSERT INTO Images (IceCreamId, Url) VALUES(12, 'https://www.benjerry.com/files/live/sites/systemsite/files/flavors/products/us/pint/peanut-butter-half-baked-detail.png');
INSERT INTO Images (IceCreamId, Url) VALUES(13, 'https://www.benjerry.com/files/live/sites/systemsite/files/flavors/products/us/mini-cups/cherry-garcia-mini-detail.png');
INSERT INTO Images (IceCreamId, Url) VALUES(14, 'https://www.benjerry.com/files/live/sites/systemsite/files/flavors/products/us/mini-cups/strawberry-cheesecake-mini-detail-2019.png');
INSERT INTO Images (IceCreamId, Url) VALUES(15, 'https://www.benjerry.com/files/live/sites/systemsite/files/flavors/products/us/pint-slices/tonight-dough-pint-slice-detail-new.png');

-- Populate categories
INSERT INTO Categories (Name, ParentCategoryId, CreatedDate, ModifiedDate) VALUES('Pints', NULL, getdate(), getdate());
INSERT INTO Categories (Name, ParentCategoryId, CreatedDate, ModifiedDate) VALUES('Mini cups', 1, getdate(), getdate());
INSERT INTO Categories (Name, ParentCategoryId, CreatedDate, ModifiedDate) VALUES('Popsicles', NULL, getdate(), getdate());
INSERT INTO Categories (Name, ParentCategoryId, CreatedDate, ModifiedDate) VALUES('Chocolate popsicle', 3, getdate(), getdate());
INSERT INTO Categories (Name, ParentCategoryId, CreatedDate, ModifiedDate) VALUES('Ice cream sandwich', NULL, getdate(), getdate());
INSERT INTO Categories (Name, ParentCategoryId, CreatedDate, ModifiedDate) VALUES('Mini popsicle', 3, getdate(), getdate());

-- Connect categories and ice creams
INSERT INTO CategoryIceCream (CategoriesId, IceCreamsId) VALUES(1, 1);
INSERT INTO CategoryIceCream (CategoriesId, IceCreamsId) VALUES(1, 2);
INSERT INTO CategoryIceCream (CategoriesId, IceCreamsId) VALUES(1, 3);
INSERT INTO CategoryIceCream (CategoriesId, IceCreamsId) VALUES(1, 4);

INSERT INTO CategoryIceCream (CategoriesId, IceCreamsId) VALUES(6, 5);
INSERT INTO CategoryIceCream (CategoriesId, IceCreamsId) VALUES(4, 6);
INSERT INTO CategoryIceCream (CategoriesId, IceCreamsId) VALUES(4, 7);
INSERT INTO CategoryIceCream (CategoriesId, IceCreamsId) VALUES(1, 8);
INSERT INTO CategoryIceCream (CategoriesId, IceCreamsId) VALUES(1, 9);
INSERT INTO CategoryIceCream (CategoriesId, IceCreamsId) VALUES(4, 10);

INSERT INTO CategoryIceCream (CategoriesId, IceCreamsId) VALUES(1, 11);
INSERT INTO CategoryIceCream (CategoriesId, IceCreamsId) VALUES(1, 12);
INSERT INTO CategoryIceCream (CategoriesId, IceCreamsId) VALUES(2, 13);
INSERT INTO CategoryIceCream (CategoriesId, IceCreamsId) VALUES(2, 14);
INSERT INTO CategoryIceCream (CategoriesId, IceCreamsId) VALUES(6, 15);