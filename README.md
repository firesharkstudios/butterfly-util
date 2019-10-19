# Butterfly.Util ![Butterfly Logo](https://raw.githubusercontent.com/firesharkstudios/Butterfly/master/img/logo-40x40.png) 

> Collection of utility methods used in the Butterfly Server

# Install from Nuget

| Name | Package | Install |
| --- | --- | --- |
| Butterfly.Web | [![nuget](https://img.shields.io/nuget/v/Butterfly.Web.svg)](https://www.nuget.org/packages/Butterfly.Web/) | `nuget install Butterfly.Web` |
| Butterfly.Web.EmbedIO | [![nuget](https://img.shields.io/nuget/v/Butterfly.Web.EmbedIO.svg)](https://www.nuget.org/packages/Butterfly.Web.EmbedIO/) | `nuget install Butterfly.Web.EmbedIO` |
| Butterfly.Web.RedHttpServer | [![nuget](https://img.shields.io/nuget/v/Butterfly.Web.RedHttpServer.svg)](https://www.nuget.org/packages/Butterfly.Web.RedHttpServer/) | `nuget install Butterfly.Web.RedHttpServer` |

# Install from Source Code

git clone https://github.com/firesharkstudios/butterfly-twilio

# Working with Dictionaries

Since *Dictionary<string, object>* is used so extensively, you'll likely find it useful to declare an alias with your other *using* statements...

```cs
using Dict = System.Collections.Generic.Dictionary<string, object>;
```

*Butterfly.Core.Util* contains a [GetAs](https://butterflyserver.io/docfx/api/Butterfly.Core.Util.DictionaryX.html#Butterfly_Core_Util_DictionaryX_GetAs__3_Dictionary___0___1____0___2_) extension method for *Dict* that makes it easier to convert values...

Here are a few common scenarios related to database records...

```cs
// Retrieve from the todo table using the primary key value
Dict row = await database.SelectRowAsync("todo", "123");

// Retrieve as string
var id = row.GetAs("id", "");

// Retrieve as integer
var count = row.GetAs("count", -1);

// Retrieve as float
var amount = row.GetAs("id", 0.0f);

// Retrieve as DateTime instance (auto converts UNIX timestamp)
var createdAt = row.GetAs("created_at", DateTime.MinValue);
```

Here are a couple common scenarios related to the Web API...

```cs
webApi.OnPost("/api/todo/insert", async (req, res) => {
    var todo = await req.ParseAsJsonAsync<Dict>();

    // Retrieve as array
    var tags = todo.GetAs<string[]>("tags", null);

    // Retrieve as dictionary
    var options = todo.GetAs<Dict>("options", null);
});
```

# Contributing

If you'd like to contribute, please fork the repository and use a feature
branch. Pull requests are warmly welcome.

# Licensing

The code is licensed under the [Mozilla Public License 2.0](http://mozilla.org/MPL/2.0/).  
