SELECT n.name as Owner_name,
COUNT(p.driver_id) AS no_of_accidents,
SUM(p.damage_amount) AS total_damage
FROM
PERSON3244 n, PARTICIPATED3244 p
WHERE
n.driver_id=p.driver_id
GROUP BY n.name
ORDER BY total_damage DESC;

commit;