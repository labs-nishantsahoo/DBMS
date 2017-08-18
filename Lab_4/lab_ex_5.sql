SELECT n.name
FROM person3244 n
LEFT JOIN PARTICIPATED3244 p ON p.driver_id = n.driver_id
WHERE p.driver_id IS NULL;

commit;