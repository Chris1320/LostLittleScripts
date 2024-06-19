#!/usr/bin/env python3

"""
The pyramid is stacked according to one simple principle:
each lower layer contains one block more than the layer above.

Write a program which reads the number of blocks the
builders have, and outputs the height of the pyramid
that can be built using these blocks.
"""

blocks = int(input("Enter the number of blocks: "))
remaining_blocks = blocks
height = 0
level_width = 1

while remaining_blocks >= level_width:
    height += 1
    remaining_blocks -= level_width
    level_width += 1

block_grammar = "blocks" if blocks > 1 else "block"
level_grammar = "levels" if height > 1 else "level"
print(
    f"With {blocks} {block_grammar}, you can build a pyramid with a height of {height} {level_grammar}."
)
