import re
# regular expression module

def isPalindrome(phare):
    forwards = ''.join(re.findall(r'[a-z]+',phare.lower()))
    backwards = forwards[::-1]
    return forwards == backwards
