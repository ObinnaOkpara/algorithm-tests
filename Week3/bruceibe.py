def code(s1, s2):
    a = set(s1)
    b = set(s2)
    
    if a & b:
        print("Yes")
    else:
        print("No")
    
code('art', 'and')