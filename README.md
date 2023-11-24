# Arion-ClaimsSignup-SampleClient
A basic .net sample client that shows examples on how to consume Claims Signup Api.

# Endpoint Ordering
The individual endpoints need to be called in a specific order to acquire desired results.

## Endpoints
### 0. api/v1/echo
Does a base check of most internal endpoints. A good way to see if the user is authenticated and has the proper user permissions

### 1. api/v1/files
The first operation that should be used.
Uploads an agreement between the third party provider (TPP) and the claimant.

### 2. api/v1/claimants
Creates an agreement between the third party provider (TPP) and the claimant. Uses the contractId returned from /files.

### 3. api/v1/claimants/{claimantId}/status
Gets the status of the created agreement.

### 4. api/v1/claimtemplates
Creates a template between TPP and Claimant, uses the agreement that is in use after /claimants

### 5. api/v1/claimtemplates/{claimTemplateId}/status
Gets the status of a template. First 10 characters are claimTemplateId, next 4 are bank, next 3 are identifier

# Useful links
https://developer-dev.arionbanki.is/