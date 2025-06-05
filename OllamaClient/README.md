# OllamaClient

A C# console application that interacts with the Ollama local LLM service to generate text responses.

## Overview

This project demonstrates how to call a local Ollama language model from a .NET 7 C# console app. It uses HTTP calls to communicate with the Ollama API running on your machine.
This is a .NET 7 C# console app that communicates with the Ollama local LLM service over HTTP on port 11434.

## Features

- Connects to Ollama running locally
- Sends prompt requests and receives generated responses
- Easy to build and run with Docker or locally using .NET SDK

## Prerequisites

## Prerequisites

- [Ollama](https://ollama.com/) installed and running locally  
  Download and install from the official site, then start the Ollama service.

- [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) installed (for local build)  
  Required if you want to build or run the app outside Docker.

- Docker installed (optional, for containerized builds)  
  Install Docker Desktop from [https://www.docker.com/get-started](https://www.docker.com/get-started).  
  To build the image:  
  docker build -t ollama-client .


## Getting Started

### Clone the repository

```bash
git clone https://github.com/shlokrekhraj/ollama-client.git
cd ollama-client
