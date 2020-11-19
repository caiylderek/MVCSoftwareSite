# MVCSoftwareSite
This an example of a software site written in ASP.NET MVC pattern.

Written in .NET Core 3.1.

# Requirements

- IDE that supports .NET Core 3.1
- Microsoft SQL Server (with Windows authentication for ease of use)
- Microsoft SQL Server Management Studio (for ease of use)

# Usage

When running in the IDE, the following logins are provided for testing

Account with randomly seeded database data\
User: caiylderek   password: caiylderek

Fresh account\
User: newuser      password: newuser

<b>Note that running this will automatically create a database via entity framework and seed random data to allow for testing, remove it either via SQL Server Management Studio or by running DROP DATABASE SoftwareSiteDb</b>

# Highlights

The following are some quick visual highlights of the project, kindly email me if you require any explanation on the implementations.

### Dynamic displaying of software in a grid directly from data retrieved from the database 
![Software grid](https://github.com/caiylderek/MVCSoftwareSite/blob/master/Screengrabs/Software.png)

### Searchbar to filter wanted software
![Searchbar gif](https://github.com/caiylderek/MVCSoftwareSite/blob/master/Screengrabs/Searchbar.gif)

### Gallery pagination
![Pagination gif](https://github.com/caiylderek/MVCSoftwareSite/blob/master/Screengrabs/Pagination.gif)

### Parsed by get method to allow link sharing
![Get parameters](https://github.com/caiylderek/MVCSoftwareSite/blob/master/Screengrabs/GetParameters.png)

### Tempdata used for flash alerts
![Flash alert gif](https://github.com/caiylderek/MVCSoftwareSite/blob/master/Screengrabs/TempdataAlert.gif)

### Allow for user ratings, AJAX call used for immediate updating of average rating
![Ratings gif](https://github.com/caiylderek/MVCSoftwareSite/blob/master/Screengrabs/Rating.gif)
