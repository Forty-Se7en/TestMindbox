select p.name, c.name
from products as p
left join products_categories as pc on p.id = pc.product_id
left join categories as c on pc.category_id = c.id 
order by p.name
