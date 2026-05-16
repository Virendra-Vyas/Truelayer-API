# TrueLayer API Integration

A .NET Core integration with the TrueLayer Open Banking API,
enabling secure access to UK bank account data, transactions,
and payment initiation via a single unified API.

## What It Does

- Connects to TrueLayer's Open Banking API using OAuth2
- Retrieves bank account information and balances
- Fetches transaction history from connected accounts
- Supports multiple UK banks via TrueLayer's unified interface
- Handles OAuth2 authentication flow and token refresh

## Tech Stack

- .NET Core / C#
- ASP.NET Core Web API
- OAuth2 / TrueLayer Authentication
- TrueLayer Data API
- REST

## Setup

1. Register your application at TrueLayer Console
2. Configure OAuth2 credentials in `_config.yml`
3. Run the solution via `TrueLayer_API.sln`

## Related Work

This project is part of broader Open Banking and financial 
API integration work, including HMRC government API 
integrations delivered as part of the IntelliBooks Global 
finance platform.
