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

    class Gun {
        - int Ammo
        + Gun (float power, int ammo)
        + void FireGun ()
    }

    class Player {
        + Player (string Name)
    }

