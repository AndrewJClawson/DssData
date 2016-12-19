CREATE TABLE IF NOT EXISTS campuses
(
	pk_campus_id int(11) unsigned NOT NULL AUTO_INCREMENT,

	name varchar(100),
	address varchar(100),
	city varchar(100),
	state varchar(100),
	zip varchar(12),

	PRIMARY KEY (pk_campus_id)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;