# OllamaClient

**OllamaClient** is a simple C# console application built with .NET 7 that communicates with the [Ollama](https://ollama.com/) local Large Language Model (LLM) service. It sends text prompts and receives generated responses from models like LLaMA 3 or Mistral running locally via the Ollama API.

---

## Overview

This project demonstrates how to:

- Set up and run a local LLM using Ollama in Docker
- Interact with it from a C# application using HTTP
- Send prompts and receive AI-generated text responses

---

## Requirements

Install the following on your system before starting:

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Docker Desktop](https://www.docker.com/get-started)
- [Git](https://git-scm.com/downloads)

---

## Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/shlokrekhraj/ollama-client.git
cd ollama-client
```

## Set Up Ollama (LLM Runtime)

### Install Docker app
### a. Pull the Ollama Docker image

```bash
docker pull ollama/ollama
```

### b. Start the Ollama container

```bash
docker run -d --name ollama \
  -p 11434:11434 \
  --restart=always \
  ollama/ollama
```
This exposes the Ollama REST API at `http://localhost:11434`.

### c. Enter the container and pull a model

```bash
docker exec -it ollama bash
```

Inside the container:

```bash
ollama pull llama3
exit
```

## 3. Run the C# Console App (Locally)

In the terminal:
```bash
dotnet clean
dotnet build
dotnet run
```
This will send a prompt to the running Ollama model and print the AI’s response in the console.

### a. Build the Docker image

```bash
docker build -t ollama-client .
```

### b. Run the container
by clicking on run button

## Project Structure

```
ollama-client/
├── Program.cs            # Main app logic
├── ollama-client.csproj
├── Dockerfile            # Optional Docker build for the C# app
├── README.md             # You're here
```

## Libraries Used
This project uses:

- `System.Net.Http` – to send HTTP POST requests  
- `System.Text.Json` – to serialize/deserialize JSON  

## Sample Output
Sending prompt to Ollama...
Response: "Sure! Here's a generated answer from the model."

## Troubleshooting
### Ollama not responding?

Make sure Docker is running and Ollama is started:

```bash
docker ps
```

### Model not found?

Enter the container and pull a model:

```bash
docker exec -it ollama bash
ollama pull llama3
```

## Customizing the Prompt

Open `Program.cs` and change the value of the prompt string. For example:

```c#
var prompt = "Write a short poem about the ocean.";
```
Rebuild and rerun the app to see the new response.

This project is for educational and internal development use. No external license applied yet.


