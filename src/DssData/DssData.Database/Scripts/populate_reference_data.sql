SELECT 'Populating table: _roles' as 'Action';
source ./ReferenceData/_roles.sql;

SELECT 'Populating table: _content_types' as 'Action';
source ./ReferenceData/_content_types.sql;

SELECT 'Populating table: _operations' as 'Action';
source ./ReferenceData/_operations.sql;

SELECT 'Populating table: _content_type_operations' as 'Action';
source ./ReferenceData/_content_type_operations.sql;

SELECT 'Populating table: _permissions' as 'Action';
source ./ReferenceData/_permissions.sql;

SELECT 'Populating table: _enrollment_statuses' as 'Action';
source ./ReferenceData/_enrollment_statuses.sql;
