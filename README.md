# Arion-ClaimsSignup-SampleClient
A basic .net sample client that shows examples on how to consume Claims Signup Api.

# Endpoint Ordering
The individual endpoints need to be called in a specific order to acquire desired results.

## Endpoints
### 0. api/v1/echo
Does a base check of most internal endpoints. A good way to see if the user is authenticated and has the proper user permissions

### 1. api/v1/claimants
Creates an agreement between the third party provider (TPP) and the claimant.

### 2. api/v1/claimants/{claimantId}/status
Gets the status of the created agreement.

### 3. api/v1/claimtemplates
Creates a template between TPP and Claimant, uses the agreement that is in use after /claimants

### 4. api/v1/claimtemplates/{claimTemplateId}/status
Gets the status of a template. claimTemplateId is returned from /claimtemplates. First 10 characters are the claimantId, next 4 are bank, next 3 are identifier

# Postman - SampleClient

### Import Postman Collection
A base sample client is available to import for Postman. You can follow the documentation to get it up and running.

File location: **postman\SampleClient.Postman_collection.json** 

### Certificates in Postman
To register a certificate in Postman the following is reccomended

Go to **File** and then **Settings**

![App Screenshot](https://github.com/arionbanki/Arion-ClaimsSignup-SampleClient/blob/main/doc-images/Postman-Cert-Auth-Step1.png)

Next go to **Certificates** and **Add Certificate**

![App Screenshot](https://github.com/arionbanki/Arion-ClaimsSignup-SampleClient/blob/main/doc-images/Postman-Cert-Auth-Step2.png)

There you need to enter the following.

**Host is apigw.arionbanki.is**

**Register your .pfx certificate**

**Enter your certificate passphrase**

![App Screenshot](https://github.com/arionbanki/Arion-ClaimsSignup-SampleClient/blob/main/doc-images/Postman-Cert-Auth-Step3.png)

You have now registered your certificate. It should now look like this

![App Screenshot](https://github.com/arionbanki/Arion-ClaimsSignup-SampleClient/blob/main/doc-images/Postman-Cert-Auth-Step4.png)

### Authorization - OAuth 2.0 
This method shows how the token is received. With this implementation the user needs to get a new access token manually.

The following needs to be configured.

**Access Token URL** - https://curity.arionbanki.is/oauth/v2/oauth-token

**Client ID** - The clientId you get from creating your application in [Developer Portal](https://developer.arionbanki.is/)

**Client Secret** - The clientSecret you get from creating your application in [Developer Portal](https://developer.arionbanki.is/)

**Scope** - The default scopes you get from creating your application in [Developer Portal](https://developer.arionbanki.is/)

Finally click **Get New Access Token**

![App Screenshot](https://github.com/arionbanki/Arion-ClaimsSignup-SampleClient/blob/main/doc-images/Postman-Curity-OAuth2.png)

You should get an OAuth token from the identity server

![App Screenshot](https://github.com/arionbanki/Arion-ClaimsSignup-SampleClient/blob/main/doc-images/Postman-Curity-OAuth2-Success.png)

You can inspect your token and make sure everything is in order

![App Screenshot](https://github.com/arionbanki/Arion-ClaimsSignup-SampleClient/blob/main/doc-images/Postman-Curity-OAuth2-Token.png)

### Variables
We reccomend setting up variables for the Api

![App Screenshot](https://github.com/arionbanki/Arion-ClaimsSignup-SampleClient/blob/main/doc-images/Postman-Variable-Settings.png)

# Useful links
https://developer.arionbanki.is/
