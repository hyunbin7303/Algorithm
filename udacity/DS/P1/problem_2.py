




## Locally save and call this file ex.py ##
# Code to demonstrate the use of some of the OS modules in python

import os
origin_path = "C:\\testdir\\"

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
    if os.path.isdir(path)== False:
        print("The path : {} not exist. ".format(path))
        return


    getall = os.listdir(path)
    for f in getall:
        path_get = os.path.join(path, path, f)
        if os.path.isfile(path_get):
            if path_get.endswith(suffix):
                list_path.append(path_get)

        else:
            path_generate = os.path.join(path, f, "")
            store = find_files(suffix, path_generate)
            for x in store:
                list_path.append(x)
   
    return list_path




print("Normal testing.")
origin_path = "C:\\testdir\\"
check = find_files(".c",origin_path)
for i in check:
    print(i)

print("Normal Testing 2 .")
origin_path = "C:\\testdir\\"
check = find_files(".h",origin_path)
for i in check:
    print(i)


print("Edge case Testing - invalid path")
origin_path = "C:\\testdir\\testdiraaa"
check = find_files(".c",origin_path)
if check == None:
    print('Path not exist.')
else:
    for i in check:
        print(i)

print("Edge testing - invalid extension")
origin_path = "C:\\testdir\\"
check = find_files(".ca",origin_path)
for i in check:
    print(i)

# Suggest using an if condition such as if os.path.isdir(path).
# os.path.isdir(path) to check whether the specified path is an existing directory or not. 
# This method follows the symbolic link, which means if the specified path is a symbolic link pointing to a directory then the method will return True.
# Follow this link to learn more