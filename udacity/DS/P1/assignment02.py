




## Locally save and call this file ex.py ##

# Code to demonstrate the use of some of the OS modules in python

import os
origin_path = "C:\\Users\\Hyunbin\\Desktop\\"

def find_files(suffix, path):
    """
    Find all files beneath path with file name suffix.
    
    Note that a path may contain further subdirectories
    and those subdirectories may also contain further subdirectories.

    There are no limit to the depth of the subdirectories can be.

    Args:
      suffix(str): suffix if the file name to be found
      path(str): path of the file system

    Returns:
       a list of paths
    """
    list_path = []
    # This could be a string or could also be a tuple of suffixes to look for.
    getall = os.listdir(path)
    for f in getall:
        check = os.path.join(origin_path, path, f)
        if os.path.isfile(check):
            if check.endswith(suffix):
                list_path.append(check)

        else:
            path_generate = os.path.join(path, f, "")
            store = find_files(".c", path_generate)
            for x in store:
                list_path.append(x)
   
    return list_path






path_generate = os.path.join(origin_path, "testdir", "testdir")
check = find_files(".c",path_generate)
for i in check:
    print(i)

