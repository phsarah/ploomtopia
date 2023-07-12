# API Ploomtopia 🌈✨

Bem-vindo à documentação oficial da API Ploomtopia! Aqui você encontrará todas as informações necessárias para interagir com nossa plataforma dedicada aos adoráveis Ploomies. 

## Introdução

Ploomtopia é um mundo virtual encantado habitado por criaturas virtuais cheias de personalidade, conhecidas como Ploomies. 
Cada Ploomie possui seu próprio nome e características únicas. 💖 Nossa API permite que você explore e aproveite a experiência com essas criaturas místicas.

## Recursos da API

### Obter todos os Ploomies 🐾

- Método: GET
- Rota: `/api/ploomies`

<br/>

Retorna uma lista de todos os Ploomies cadastrados no mundo de Ploomtopia.

<br/>

Exemplo de sucesso (200):
```json
[
  {
    "id": 1,
    "name": "Fuzzball",
    "traits": ["Curious", "Friendly"],
    "hungerLevel": 3,
    "happinessLevel": 5
  },
  {
    "id": 2,
    "name": "Snuggles",
    "traits": ["Playful", "Loyal"],
    "hungerLevel": 2,
    "happinessLevel": 4
  },
  // Outros Ploomies...
]
```

<br/>
<hr/>


### Obter um Ploomie específico 🐾🔍

- Método: GET
- Rota: `/api/ploomies/{id}`
  
- Parâmetros de URL: `{id}: O ID do Ploomie desejado.`

<br/>

Retorna as informações detalhadas de um Ploomie com base no ID fornecido.

<br/>

Resposta de Sucesso (200 OK):
```json
{
  "id": 1,
  "name": "Fuzzball",
  "traits": ["Curious"]
  "hungerLevel": 3,
  "happinessLevel": 5
}
```

<br/>
<hr/>

### Criar um novo Ploomie 🎉✨

- Método: POST
- Rota: `/api/ploomies`

<br/>

Cria um novo Ploomie no mundo de Ploomtopia com base nas informações fornecidas. Certifique-se de enviar um objeto JSON contendo o nome e as características especiais do novo Ploomie.

<br/>

Corpo da Solicitação (JSON):

```json
{
  "name": "Fluffy",
  "traits": ["Curious", "Playful"]
}
```

<br/>


Resposta de Sucesso (201 Created):

```json
{
  "id": 3,
  "name": "Fluffy",
  "traits": ["Curious", "Playful"]
  "hungerLevel": 0,
  "happinessLevel": 0
}
```

<br/>
<hr/>


### Atualizar um Ploomie 🔄🚀

- Método: PUT
- Rota: `/api/ploomies/{id}`

<br/>

Atualiza as informações de um Ploomie existente com base no ID fornecido. Envie um objeto JSON contendo as informações atualizadas do Ploomie.

<br/>

Resposta de Sucesso (200 OK):

```json
{
  "message": "Ploomie atualizado com sucesso"
}
```

<br/>
<hr/>


### Remover um Ploomie ❌🔥

- Método: DELETE
- Rota: `/api/ploomies/{id}`

<br/>

Remove um Ploomie específico com base no ID fornecido. Esteja ciente de que essa ação é irreversível.

<br/>

Resposta de Sucesso (200 OK):

```json
{
  "message": "Ploomie removido com sucesso"
}
```

<br/>

