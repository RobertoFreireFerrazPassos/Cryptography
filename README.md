# Cryptography

## Encryption

Encryption is masking or hiding the data by changing the format so that it’s unreadable or indecipherable unless you have the means to decrypt it, so the data remains in place but gets scrambled or hidden.

### Symmetric encryption

- Encrypter, and decrypter — need access to the same key.
- The tricky part is how to store the key and make it available only to the software that needs it.

<p align="center">
  <img src="https://github.com/RobertoFreireFerrazPassos/Cryptography/blob/main/Img/SymmetricEncryption.PNG?raw=true">
</p>

### Asymmetric encryption

- Uses public and private keys to encrypt and decrypt data.
- Either of the keys can be used to encrypt a message; the opposite key from the one used to encrypt the message is used for decryption.

<p align="center">
  <img src="https://github.com/RobertoFreireFerrazPassos/Cryptography/blob/main/Img/AsymmetricEncryption.PNG?raw=true">
</p>

## Hash 

- Hashing is used only to verify data
- The same input will always produce the same output
- It’s impossible to reverse it back to the original data
- Given knowledge of only the hash, it’s infeasible to create another string of data that will create the same hash 

<p align="center">
  <img src="https://github.com/RobertoFreireFerrazPassos/Cryptography/blob/main/Img/Hashing.PNG?raw=true">
</p>

## Token

Tokenization is a process where one tries not to possess the data. It’s a proxy to sensitive information with equivalent non-sensitive information which is the token. In the case of merchants using credit card numbers, instead of encrypting the information one stores it and assigns a key. Just think of it as a vault.

<p align="center">
  <img src="https://github.com/RobertoFreireFerrazPassos/Cryptography/blob/main/Img/Token.PNG?raw=true">
</p>

## JWT

Json Web Tokens are a stateless solution for authentication. So there is no need to store any session state on the server

- Assuming we already have a registered user in our database, the user will make a login request. 
- If the user exists and if the password is correct, the application will generate a unique JWT
- The token is created using a secret string that is stored on a server. 
- The server then sends that JWT back to the client which will store it either in a cookie or in local storage.

<p align="center">
  <img src="https://github.com/RobertoFreireFerrazPassos/Cryptography/blob/main/Img/JWT2.png?raw=true">
</p>

- So the server does in fact not know which user is actually logged in, but of course, the user knows that he's logged in because he has a valid Json Web Token which is a bit like a passport to access protected parts of the application.
- Then, each time a user wants to access a protected route like his user profile data, for example. He sends his Json Web Token along with a request, so it's a bit like showing his passport to get access to that route.
- All this communication must happen over https to prevent that anyone can get access to passwords or JWT

<p align="center">
  <img src="https://github.com/RobertoFreireFerrazPassos/Cryptography/blob/main/Img/JWT3.png?raw=true">
</p>

- JWT has a header, a payload and a signature
- Header and payload must not store any sensitive data


<p align="center">
  <img src="https://github.com/RobertoFreireFerrazPassos/Cryptography/blob/main/Img/JWT4.png?raw=true">
</p>

- The signature is created using the header, the payload, and the secret that is saved on the server.
- Once the JWT is received on the server in a protected route, the verification will take its header and payload, and together with the secret that is still saved on the server, it creates a test signature.
- If the test signature is the same as the original signature, then it means that the payload and the header have not been modified.

<p align="center">
  <img src="https://github.com/RobertoFreireFerrazPassos/Cryptography/blob/main/Img/JWT1.png?raw=true">
</p>

## References:

https://peter-chang.medium.com/review-3-main-types-of-encryption-hash-symmetric-asymmetric-tutorial-example-understand-5e57c290324c

https://www.c-sharpcorner.com/article/encryption-and-decryption-using-a-symmetric-key-in-c-sharp/

https://www.c-sharpcorner.com/article/implement-symmetric-and-asymmetric-cryptography-algorithms-with-c-sharp/