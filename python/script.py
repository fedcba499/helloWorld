import os
import random
import time

numRows = 4
numCols = 5

if (numRows * numCols ) % 2 != 0:
    raise ValueError("There must be an even number of spots.")

hiddenCard = "?"
emptySpot = " "
delay = 2  # time in seconds cards are revealed for.

def clear():
    pass

def printTitle():
    pass