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
    