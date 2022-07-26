<div align="center">
<img src="./Assets/GeracaoTechUnimedBHFullstack-Logo.png" alt="Bootcamp Logo" width="200px" height="200px">
<h1>.Net6 and XUnit</h1>
</div>

This project uses:
- Solutions
- Projects
- References
- Unit Tests

If you are in the solution folder, To run the application run the bash code bellow to execute with 2 simple param calculations:

```dotnet run --project ./Calculator $1 $2 $3```

where:
- [$1:]() First number
- [$2:]() Aritmetic Symbol (+, -, *, /)
- [$3:]() Third number

## Logging
Every calculation made is stored within a log file, located at:

```Calculator/Logs/Log.log```

---

## XUnit Test

To run the test made with XUnit:

Terminal output:
- ```dotnet test --nologo --logger "console verbosity=detailed"```

    output: ```integrated terminal```

Html Page output:
- ```dotnet test --logger "html;logfilename=Results.html;"```

    output: ```UnitTests/TestResults/```
