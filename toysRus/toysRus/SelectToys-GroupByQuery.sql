select type_name,count(*)
from toys
left join toy_types
  on toy_types.id = toys.type_id
group by type_name
;