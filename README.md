# WPF integration with oracle
1. Oracle DB version:
- https://www.oracle.com/database/technologies/dotnet-utilsoft-downloads.html
- https://www.oracle.com/database/technologies/xe-prior-release-downloads.html (old version)


2. Oracle DB credentials:
- password : ```test```

3. Oracle server ports:
Port for 'Oracle Database Listener': 1521
Port for 'Oracle Services for Microsoft Transaction Server': 2030
Port for 'Oracle HTTP Listener': 8080

4. Install jdk:
- https://www.oracle.com/java/technologies/downloads/#jdk18-windows


5. Connect to Oracle server:
- cd C:\"Folder"\app\oracle\product\11.2.0\server\bin
- ```sqlplust connect``` (username: ```SYSTEM```, password: ```test```)
5.1 Create user

grant CREATE SESSION, ALTER SESSION, CREATE DATABASE LINK, -
  CREATE MATERIALIZED VIEW, CREATE PROCEDURE, CREATE PUBLIC SYNONYM, -
  CREATE ROLE, CREATE SEQUENCE, CREATE SYNONYM, CREATE TABLE, - 
  CREATE TRIGGER, CREATE TYPE, CREATE VIEW, UNLIMITED TABLESPACE -
  to smith;
  
  
6. Install SQL developer (to view the DBs, table etc in the browser)
- https://www.oracle.com/tools/downloads/sqldev-downloads.html
- ![image](https://user-images.githubusercontent.com/45095003/164933714-1cc2be37-acc1-4c61-9037-411b2c1ed64e.png)

7. Connection string:
- https://www.connectionstrings.com/oracle/ 
- example ```Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=xe)));User Id=smith;Password=password;```

