SELECT Products.title, Category.title
	FROM Products
LEFT JOIN ProCat
	On Products.id = ProCat.id_product
LEFT JOIN Category
	ON ProCat.id_category = Category.id