select dept
from course3244
where courseid = (select courseid 
                 from book_adoption3244
                 group by courseid
                 having count(distinct book_isbn)>1);               