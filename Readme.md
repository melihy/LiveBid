/src
    AuctionService
    GatewayService
    IdentityService
    SearchService
    Contracts

    * add new dotnet webapi project to a specific folder:
        dotnet new webapi -o src/BiddingService
    * add new added project to the solution
        dotnet sln add src/BiddingService
    docker-compose.yml
        docker compose up -d 
    
/frontend
    web-app
        * frontend with react
            to build for dev. environment, run: npm run dev


git:
    git add . 
    git commit -m "--commit comments here--"
    git push origin main      

docker:
    *   docker compose build
    **      Build or rebuild services, If you change a service's Dockerfile or the contents of its build directory, run docker compose build to rebuild it.
    *   docker compose down
    **      Stops containers and removes containers, networks, volumes, and images created by up
    *   docker compose up -d 
    **      Create and start containers. Builds, (re)creates, starts, and attaches to containers for a service.
    **      -d, --detach	Detached mode: Run containers in the background

mkcert:
    *   mkcert -key-file server.key -cert-file server.crt app.livebid.com api.livebid.com

kubernetes:
    *   kubectl apply -f webapp-depl.yml
    **  kubectl rollout restart deployment webapp
    **  if exists:
        kubectl delete secret livebid-app-tls
        create:
    *** kubectl create secret tls livebid-app-tls --key server.key --cert server.crt 
    *** delete all kubernete containers:
        kubectl delete -f K8S/
    ***
        kubectl create secret generic postgres-password --from-literal=postgrespwkey=somerandompw
        kubectl run -it --rm --image=postgres --restart=Never pg-client --env="PGPASSWORD=somerandompw" -- psql -h postgres-clusterip -U postgres
        kubectl port-forward svc/postgres-clusterip 5432:5432
        kubectl get secrets


