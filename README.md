# Configurados
Configuration service for the desperate

## What/Why is this?

This project is a _proof of concept_ for a configuration service. 
A configuration service is essentially an independent bank of information that can be queried by other services.
The information stored can be unique to each service, or it can be common information such as constants or company- or environment-wide information.

There are many reasons as to why you may or may not want to have a service that handles configuration.

## How does it work?

Essentially the information kept by the service is a JSON object (hence a hierarchical data structure - as opposed to flat, tag-based, etc).
Other services can query or update the configuration using specific keys, and the corresponding JSON "sub-tree" will be returned or updated if it exists.

For example, if my entire configuration is this object

```json
{
  "constants": {
    "pi": 3.14159,
    "phi": 1.6180,
    "e": 2.71828
  },
  "food": {
    "food i like": ["pizza without pinapple", "burger", "goulash"],
    "food i don't like" : ["pizza with pinapple"]
  }
}
```

then asking for the keys 

* `constants.pi`
* `constants`
* `food.food i like`

returns 

* `3.14159`
* `{"pi": 3.14159, "phi": 1.6180, "e": 2.71828}`
* `["pizza without pinapple", "burger", "goulash"]`

respectively.

There is also an event store that saves the changes and records each author for auditing purposes. 
The current implementation uses a [Streak](https://www.nuget.org/packages/Streak/), but it could be implemented so that it uses Git or some other type of storage.

## Does it work?

As I mentioned before it's a proof of concept so there's many ways to break it. Don't use it for production. 
However you can run it and try importing a few configs and then loading them to get a feel of how it would work for you or just use it as inspiration for building a proper configuration service.
