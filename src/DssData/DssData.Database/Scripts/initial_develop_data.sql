
SELECT 'Populating table: campuses' as 'Action';
INSERT INTO campuses VALUES (1,"First Campus","345 Fake St.","My City","CO","80233");

INSERT INTO dssdata_auth.users("e1e6f670-1bf0-44cc-a34e-7d7f443567dc","andrewjclawson18@gmail.com",
SELECT 'Populating table: profiles' as 'Action';
INSERT INTO profiles VALUES (1,"e1e6f670-1bf0-44cc-a34e-7d7f443567dc",1,"Andrew","Clawson");

SELECT 'Populating table: profile_permissions' as 'Action';
INSERT INTO profile_permissions VALUES(1,1,1);
INSERT INTO profile_permissions VALUES(2,1,2);
INSERT INTO profile_permissions VALUES(3,1,3);
INSERT INTO profile_permissions VALUES(4,1,4);
INSERT INTO profile_permissions VALUES(5,1,5);
INSERT INTO profile_permissions VALUES(6,1,6);
INSERT INTO profile_permissions VALUES(7,1,7);
INSERT INTO profile_permissions VALUES(8,1,8);

SELECT 'Populating table: school_years' as 'Action';
INSERT INTO school_years VALUES (1,"2013-2014");
INSERT INTO school_years VALUES (2,"2014-2015");
INSERT INTO school_years VALUES (3,"2015-2016");
INSERT INTO school_years VALUES (4,"2016-2017");

INSERT INTO quarters VALUES (1,1,1);
INSERT INTO quarters VALUES (2,1,2);
INSERT INTO quarters VALUES (3,1,3);
INSERT INTO quarters VALUES (4,1,4);
INSERT INTO quarters VALUES (5,2,1);
INSERT INTO quarters VALUES (6,2,2);
INSERT INTO quarters VALUES (7,2,3);
INSERT INTO quarters VALUES (8,2,4);
INSERT INTO quarters VALUES (9,3,1);
INSERT INTO quarters VALUES (10,3,2);
INSERT INTO quarters VALUES (11,3,3);
INSERT INTO quarters VALUES (12,3,4);
INSERT INTO quarters VALUES (13,4,1);
INSERT INTO quarters VALUES (14,4,2);
INSERT INTO quarters VALUES (15,4,3);
INSERT INTO quarters VALUES (16,4,4);
