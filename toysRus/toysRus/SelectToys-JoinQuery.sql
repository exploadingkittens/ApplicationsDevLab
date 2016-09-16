select 
	toys.toy_name as Name,
	toy_types.type_name as Type,
	suppliers.supplier_name as Supplier,
	CONCAT('USD $',toys.price) as Price,
	toys.amount as 'Items in Stock'
from toys
left join toy_types
  on toy_types.id = toys.type_id
left join suppliers
  on suppliers.id = toys.supplier_id
;

