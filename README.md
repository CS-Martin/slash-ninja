# **SlashNinja**
> An immersive computer vision arcade game that combines the excitement of gaming with the benefit of physical activity.

### **Contributors**
- [**Albert Perez**](https://github.com/bibookss)
- [**Martin Atole**](https://github.com/CS-Martin)
- [**Gabriel Reuyan**](https://github.com/jobb-rodriguez)

---
## **Conventions**
1. **Github**
    - Commits:
        ``` shell
        git commit -m [action]: [description]
        ```
        - Action:
            | Option | Information |
            | :---: | :--- |
            | `Info`| Include in the `[description]` what was the `commit` about. |
            | `Add` | Include in the `[description]` when adding or creating a `directory/`, `file/`, or a `feature`. |
            | `Update` | Include in the `[description]` when updating or modifying a `directory/`, `file/`, or a `feature`. |
            | `Delete` | Include in the `[description]` when deleting a `directory/`, `file/`, or a `feature`. |
            | `Bugfix` | Include in the `[description]` what was the bug's description in a `file/` or `feature`. |
    - Branching:
        ``` shell
            git branch '[layer]/[description]' '[commit-hash]'
            --- or ---
            git checkout -b '[layer]/[description]' '[commit-hash]'
        ```
        - Layer:
            - `frontend` - A branch that concerns the frontend (**presentation layer**) of the project.
            - `backend` - A branch that concerns the backend (**data access layer**) of the project.
        - Description:
            - Options: `feature`, `description`, or `bugfix`.
        - Commit Hash (Optional):
            - Create a branch of `[layer]/[description]` from a previous commit using the `[commit-hash]`.q
---
