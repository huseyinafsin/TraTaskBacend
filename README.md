
# Giriş

Bu program basit bir login olma ve bir sayfaya erişim sağlama işlevine sahiptir.


* [Bu Programın React ile yazılmış arayüzüne erişmek için tıklayın](https://github.com/huseyinafsin/TraTaskReact-)

* [Bu Programa ait Database şemasını görmek için tıklayın](https://github.com/huseyinafsin/TraTaskBackend/blob/main/DbSchema.MD)


## Main path
  `[METHOD_TYPE] [site_url]/api/[controller_name]/[action]/id`
   

    ### Port Numaraları

  Ortam  | Port Numarası (Http,Https)
  ---------  | -----------
   IIS | 39758,44359
   Project |5000, 5001
   Docker| 49153

   
 ## Login olma işlemi
Bu metod api üzerinde login olup token almak işlemi için kullanılır. Metod tipi POST'tur

`POST [https:localhost:5001]/api/auth/login`

  ### Query Parameters

  Parameter  | Description
  ---------  | -----------
   Authorization | "Bearer " + token
  


  ### Response 
```shell
  #Bu metod bu şekilde sonuş vermektedir:

  ```json
 {
    "success": true,
    "message": "Login Successful!",
    "accessToken": {
        "token": "eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTUxMiIsInR5cCI6IkpXVCIsImN0eSI6IkpXVCJ9.eyJuYmYiOjE2NTQxNTEwNDYsImV4cCI6MTY1NDE1NDY0NiwiaXNzIjoiaHR0cHM6Ly9naXRodWIuY29tL2h1c2V5aW5hZnNpbi8iLCJhdWQiOiJodHRwczovL2dpdGh1Yi5jb20vaHVzZXlpbmFmc2luLyJ9.UDiJlng9IvnbleT9pZoCwIJAPhHOmtiIy_fYgQgoNW8FYmS7IWbQHrjc8mo8i4Q-e2tH8HnLpH0wp1Gq6kFx0A",
        "expiration": "2022-06-02T10:24:06.6585836+03:00"
    },
    "user": {
        "username": "huseyin",
        "firstname": "Hüseyin",
        "lastname": "Afşin"
    }
}
  ```
 ## Profile
Bu metod api token kullanarak profil bilgilerine erişimi sağlayan bir istektir ve GET metodudur.

`GET [https:localhost:5001]/api/profile`

  ### Body Parameters

```
  "user": {
        "username": "<username>",
        "firstname": "<password>",
    }
```
  User List
  --------- 
   user: huseyin, password : 12345

  ### Response 
```shell
  #Bu metoda doğru token gönderildiğinde bu şekilde sonuş vermektedir:

  ```json
 {
    "result": "Logged in Successful",
 }
  ```


  </aside>


  
    
  #### Technologies
- .NET Core 3.1
- Asp.NET for Restful Api
- MsSql
- Entity Framework
- Automapper

#### Techniques
- JWT (Json Web Tokens)
- IoC 
- Autofac Dependency Resolver



