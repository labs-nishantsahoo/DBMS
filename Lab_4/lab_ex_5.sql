select n.name
from person3244 n
left join participated3244 p on p.driver_id=n.driver_id
where p.driver_id is null;

commit;