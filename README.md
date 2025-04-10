# UML

```mermaid

classDiagram
    class Character {
        # Weapon [] weapons
        + string Name
        + void Fight ()
    }

    class Weapon {
        # float power
        + Weapon (float weapon) 
    }


    class Enemy {
        + Enemy (string Name)        
    }

