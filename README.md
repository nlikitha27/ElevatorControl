# Elevator Control

## Scenarios

Supply API over http used by multiple teams to control an elevator:

- user request to current floor.
- user request to stop at specified floor.
- car request for all current floor requests.
- car request for next floor to be serviced.

## Build/run

- From the root of the project run, `dotnet run --project .\ElevatorControl\ElevatorControl.csproj` will run at port 8080 through the appsettings.json configuration.

Accepted calls:
- PUT http://localhost:8080/API/Elevator/put?floor={N}&dir={1,-1}
- PUT http://localhost:8080/API/Elevator/put?floor={N}
- GET http://localhost:8080/API/Elevator/all
- POST http://localhost:8080/API/Elevator/next

# Questions and TODO

- Need to impliment authentication.
- Assuming multiple elevators in API, will restrict to 1 in code.

## 