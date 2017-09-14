DELETE FROM COURSE3244;
DELETE FROM ENROLL3244;
DELETE FROM STUDENT3244;
DELETE FROM book_adoption3244;
DELETE FROM text3244;

INSERT ALL
INTO STUDENT3244 (regno,name,major,bdate) VALUES ('53256','Manish Agnihotri','CCE','24-Jul-1996')
INTO STUDENT3244 (regno,name,major,bdate) VALUES ('53174','Aditya Rathod','CCE','29-Oct-1995')
INTO STUDENT3244 (regno,name,major,bdate) VALUES ('53244','Nishant Sahoo','CCE','02-Feb-1997')
INTO STUDENT3244 (regno,name,major,bdate) VALUES ('53260','Zoheb Shujauddin','CCE','15-Sep-1996')
INTO STUDENT3244 (regno,name,major,bdate) VALUES ('03244','Dhimant M Ranipa','CSE','05-Nov-1997')
SELECT * FROM dual;

INSERT all
into COURSE3244 (COURSEID,cname,dept) VALUES (1,'Biology','BIO')
into COURSE3244 (COURSEID,cname,dept) VALUES (2,'Computer Science','CSE')
into COURSE3244 (COURSEID,cname,dept) VALUES (3,'Info Elect','ICT')
into COURSE3244 (COURSEID,cname,dept) VALUES (4,'Zoology','ZOO')
into COURSE3244 (COURSEID,cname,dept) VALUES (5,'Comp Economics','ECO')
select * from dual;

insert all
into enroll3244 (regno,COURSEID,sem,book_isbn) VALUES ('53256',1,5,56)
into enroll3244 (regno,COURSEID,sem,book_isbn) VALUES ('53244',2,5,69)
into enroll3244 (regno,COURSEID,sem,book_isbn) VALUES ('53174',3,5,11)
into enroll3244 (regno,COURSEID,sem,book_isbn) VALUES ('03244',4,5,72)
into enroll3244 (regno,COURSEID,sem,book_isbn) VALUES ('53260',5,5,89)
select * from dual;

insert all
into book_adoption3244 (courseid,sem,book_isbn) VALUES (1,5,1)
into book_adoption3244 (courseid,sem,book_isbn) VALUES (2,5,2)
into book_adoption3244 (courseid,sem,book_isbn) VALUES (3,5,3)
into book_adoption3244 (courseid,sem,book_isbn) VALUES (4,5,4)
into book_adoption3244 (courseid,sem,book_isbn) VALUES (5,5,5)
select * from dual;

insert all
into enroll3244 (regno,COURSEID,sem,book_isbn) VALUES ('53256',1,5,56)
into enroll3244 (regno,COURSEID,sem,book_isbn) VALUES ('53244',2,5,69)
into enroll3244 (regno,COURSEID,sem,book_isbn) VALUES ('53174',3,5,11)
into enroll3244 (regno,COURSEID,sem,book_isbn) VALUES ('03244',4,5,72)
into enroll3244 (regno,COURSEID,sem,book_isbn) VALUES ('53260',5,5,89)
select * from dual;

insert all
into text3244 (book_isbn, booktitle, publisher, author) VALUES (1,'B1','Nishant','Nishant')
into text3244 (book_isbn, booktitle, publisher, author) VALUES (2,'B2','Manish','Manish')
into text3244 (book_isbn, booktitle, publisher, author) VALUES (3,'B3','Kanishk','Kanishk')
into text3244 (book_isbn, booktitle, publisher, author) VALUES (4,'B4','Samarth','Samarth')
into text3244 (book_isbn, booktitle, publisher, author) VALUES (5,'B5','Neelesh','Neelesh')
select * from dual;

COMMIT;