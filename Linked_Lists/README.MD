# Linked Lists

A linked list is a linear data structure, in which the elements are not stored at contiguous memory locations. The elements in a linked list are linked using pointers.

Node 1 Node 2 Node 3
+---+ +---+ +---+
| 1 | ---> | 2 | ---> | 3 |
+---+ +---+ +---+

below is the latex version:

\begin{figure}[h]
  \centering
  \begin{tikzpicture}[node distance=1.5cm]
    % Nodes
    \node (node1) [draw, circle] {1};
    \node (node2) [draw, circle, right of=node1] {2};
    \node (node3) [draw, circle, right of=node2] {3};

    % Arrows
    \draw[->] (node1) -- (node2);
    \draw[->] (node2) -- (node3);
  \end{tikzpicture}
  \caption{Linked List with Three Nodes}
\end{figure}
