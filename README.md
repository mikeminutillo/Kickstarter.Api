# Unofficial Kickstarter API

Originally based on the work done at http://syntaxi.net/2013/03/24/let-s-explore-kickstarter-s-api/

NOTE: This API is completely unofficial and may break at a moments notice. It has already done so at least once since I started this project!

This is a very simple Kickstarter Api that I use to collect project data.

Usage:

1. Create an instance of `KickstarterClient` (optionally providing a client id)
2. Call the `StartSession` method passing in your email address and kickstarter password
3. Call the `Get<TResult>` and `Post<TResult>` methods on the session. These are very low level and are useful for checking what's happening under the covers. You can get raw returned info by calling `Get<JToken>` or `Post<JToken>` and calling `.ToString()` on the result.
4. Alternatively call the higher level `.Query<TResult>()` method and pass in a prepackaged Query object. There are currently 3: AllCategories, FindCategory, and DiscoverProjects (this is the one you will use most often).


LINQPad Sample
```csharp
var client = new KickstarterClient();

var session = await client.StartSession(EMAIL, PASSWORD);

var tableTop = await session.Query(new FindCategory("Tabletop Games"));

var query = new DiscoverProjects()
              .InCategory(tableTop)
              .InStatus("live")
              .SortedBy("launch_date")
              .Take(200);

(from p in await session.Query(query) orderby p.LaunchedAt select p).Dump();
```

NOTES: 
* If you don't provide a sort to DiscoverProjects it seems to duplicate projects
