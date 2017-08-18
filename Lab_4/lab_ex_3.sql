SELECT n.name as Owner_name,
count(p.driver_id) as no_of_accidents,
sum(p.damage_amount) as total_damage
from
person3244 n,participated3244 p
where
n.driver_id=p.driver_id
group by n.name
order by total_damage DESC;

commit;