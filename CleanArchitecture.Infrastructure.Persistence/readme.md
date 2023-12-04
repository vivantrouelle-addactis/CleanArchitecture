# Insert Data

```
INSERT INTO public."Users"(
	"Id", "Email", "firstName", "lastName", "DateCreated", "DateUpdated", "DateDeleted")
	VALUES (uuid_generate_v4(), 'john.doe@amail.com', 'John', 'Doe', NOW(), NOW(), NOW());
```