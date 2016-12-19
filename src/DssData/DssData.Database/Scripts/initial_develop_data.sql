
SELECT 'Populating table: campuses' as 'Action';
INSERT INTO campuses VALUES (1,"First Campus","345 Fake St.","My City","CO","80233");

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
