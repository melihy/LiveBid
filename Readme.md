# Microservices-based Auction Application

This repository contains the microservices-based auction application that I developed as part of the "Build a Microservices App with .NET and Next.js from Scratch" course by Neil Cummings on Udemy. The project allowed me to gain hands-on experience in microservices architecture, modern frontend development, and cloud-native deployment.

## Purpose
The purpose of this project was to deepen my understanding of microservices and to apply the concepts in a real-world scenario. By following the course, I was able to explore the following areas:

### Developing backend services using .NET
Implementing service-to-service communication with RabbitMQ and gRPC.
Managing authentication and authorization with IdentityServer.
Creating a gateway with Microsoft YARP.
Building a modern client-side app with Next.js using the App Router.
Using SignalR for real-time push notifications.
Containerizing services with Docker.
Automating CI/CD workflows with GitHub Actions.
Configuring ingress controllers.
Deploying the application locally with Docker Compose.
Running unit and integration tests.
Publishing to a Kubernetes cluster, both locally and on the internet.

#### Key Learning Outcomes

1. Backend Services with .NET
Developed several backend services that provide functionality for the auction application, enhancing my knowledge of microservices architecture.

2. Service-to-Service Communication
Implemented RabbitMQ and gRPC for efficient communication between services.

3. Identity Management
Utilized IdentityServer as the identity provider, securing the application with modern authentication protocols.

4. API Gateway
Created a gateway using Microsoft YARP, streamlining requests between the client and backend services.

5. Frontend Development
Built a client-side application with Next.js, leveraging the latest App Router functionality introduced in version 13.4.

6. Real-Time Communication
Integrated SignalR to enable push notifications and real-time updates in the client application.

7. Containerization and Deployment
Dockerized services, set up CI/CD workflows with GitHub Actions, and managed deployment with Docker Compose and Kubernetes.

8. Testing and Quality Assurance
Performed unit and integration testing to ensure code quality and robustness.

#### Technologies Used

**Backend:** .NET Core, RabbitMQ, gRPC, IdentityServer

**Frontend:** Next.js (App Router)

**Real-Time Communication:** SignalR

**Containerization:** Docker, Kubernetes

**CI/CD:** GitHub Actions

**API Gateway:** Microsoft YARP

### How to Run
**Clone the Repository:**

```bash
git clone https://github.com/melihy/LiveBid.git
```


**Run Locally:** Use Docker Compose to run the application locally.

```bash
docker-compose up
```

**Deploy to Kubernetes:**

 Follow the steps in the *k8s-deploy.md* to publish the app to a Kubernetes cluster.

## Acknowledgments

This project is based on the course "Build a Microservices App with .NET and Next.js from Scratch" by Neil Cummings, available on Udemy [Link Here](https://www.udemy.com/course/build-a-microservices-app-with-dotnet-and-nextjs-from-scratch), and I highly recommend to anyone who has curiousity for microservices-based application architecture.

Contact Information
Feel free to reach out for any questions or collaboration opportunities:

[Melih Ayhan](https://github.com/melihy)
