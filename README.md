# 🛰️ AWS Lambda + Step Functions + Kafka Orchestration

This project demonstrates an event-driven architecture using **AWS Step Functions** to orchestrate **.NET-based AWS Lambda** functions, and **Apache Kafka** (via Docker) as a reliable message broker.

> ✅ This is the AWS equivalent of an Azure Durable Function orchestration pattern.

---

## 🧩 Architecture Overview

- **AWS Step Functions** define the orchestration flow using Amazon States Language (ASL).
- **AWS Lambda (C# / .NET 8)** functions perform individual steps like generating messages or processing data.
- **Apache Kafka** (via Docker) is used for asynchronous messaging.
- **.NET Core Console App** acts as the Kafka consumer, reading messages in real time.

---

## 📂 Project Structure

```plaintext
AWS-Orchestration-Project/
│
├── src/
│   ├── SayHelloFunction/           # Lambda function to say hello
│   ├── KafkaPublisherFunction/     # Lambda function to publish to Kafka
│   ├── Orchestrator/
