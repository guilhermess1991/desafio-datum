<h1 align="center">Desafio Datum - Calular Taxa de Juros</h1>
<p align="center">Projeto desenvolvido como desafio para seleção de pessoa Desenvolvedora .Net Core</p>

Tabela de conteúdos
=================
<!--ts-->
   * [Composição do projeto](#composição)
   * [Como executar](#como-executar)
     * [Requisitos](#requisitos)
     * [Docker & Docker-Compose](#docker--docker-compose)    
   * [Tecnologias](#tecnologias)
<!--te-->

## Composição

Este projeto é divido em duas partes:
1. API - Taxa de Juros (pasta API_1) 
2. API - Calculadora de Juros (pasta API_2)

O projeto com a calculadora depente da execução da API - Taxa de Juros.

## Como executar
#### Requisitos

- .Net Core 3.1+ (https://dotnet.microsoft.com/download)
- Docker  (https://www.docker.com/get-started)

#### Docker & Docker-Compose

Para iniciar o projeto, será preciso acessar o diretorio onde se encontra o arquivo Docker-compose.yalm via terminal e executar o seguinte comando:

```bash
$ docker-compose up -d
```

Após o termino da execução do comando acima, já possivel acessar a interface do Swagger e desfrutar dos dois endpoints disponíveis.

- /calculajuros (Calcula taxa de juros)
- /showmethecode (Busca URL referente do código fonte deste projeto disponibilizado no Github)

---

## Tecnologias

As seguintes ferramentas foram usadas na construção do projeto:

-   **[.Net Core 3.1](https://github.com/ReactTraining/react-router/tree/master/packages/react-router-dom)**
-   **[Swagger](https://github.com/swagger-api)**
-   **[GitHub REST API](https://docs.github.com/en/rest)**
-   **[xunit](https://github.com/xunit)**
-   **[Docker](https://github.com/docker)**

## Autor

<a href="https://github.com/guilhermess1991">
 <img style="border-radius: 50%;" src="https://avatars.githubusercontent.com/u/19257937?s=400&u=8f4d00c15fab83157f82db2f78cd4f21595bcf1a&v=4" width="100px;" alt="Foto do Guilherme Santos Souza"/>
 <br />
 <sub><b>Guilherme Santos Souza</b></sub></a> <a href="https://github.com/guilhermess1991" title="Github do Guilherme Santos Souza"></a>
 <br />

[![Linkedin Badge](https://img.shields.io/badge/-Guilherme%20Santos%20Souza-blue?style=flat-square&logo=Linkedin&logoColor=white&link=https://www.linkedin.com/in/guilhermesouza-ads/)](https://www.linkedin.com/in/guilhermesouza-ads/) 
