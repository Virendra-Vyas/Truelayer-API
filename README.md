# TrueLayer_API

This api is used to connect to TrueLayer Api to fetch Mock Bank Account details
API has 3 controller which exposing the method explained later
Controller are:

1. AccountsController : gives account and account transactions details
2. AuthController : Used to manage user authorization flow
3. CallbackController : handling the callback from the TrueLayer auth dialog (callback uri: http://localhost:3000/callback)

Controllers interact with the api service to get data from truelayer.

# build the application and launch in debug mode

AccountsController Method available are:

1. Get Accounts details
URI: http://localhost:3000/accounts/56c7b029e0f8ec5a2334fb0ffc2fface

2. Get Account details by account id
URI: http://localhost:3000/accounts/56c7b029e0f8ec5a2334fb0ffc2fface

3. Get Transactions details for an account id
URI: http://localhost:3000/accounts/56c7b029e0f8ec5a2334fb0ffc2fface/transactions

4. Get Min Max Amount and other Transactions details for an account id .. showing as a snapshot
URI: http://localhost:3000/accounts/56c7b029e0f8ec5a2334fb0ffc2fface/transactions/snapshot

# appsettings.Development.json
This json capture all the API level details. Used HandlerSettings class to map the appsettings

## Set Redirect URI in from CallbackController.cs

Set URI inside in this statement: `return Redirect("/accounts/56c7b029e0f8ec5a2334fb0ffc2fface/transactions");`

