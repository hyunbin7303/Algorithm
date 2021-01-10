# Active Directory.
class Group(object):
    def __init__(self, _name):
        self.name = _name
        self.groups = []
        self.users = []

    def add_group(self, group):
        self.groups.append(group)

    def add_user(self, user):
        self.users.append(user)

    def get_groups(self):
        return self.groups

    def get_users(self):
        return self.users

    def get_name(self):
        return self.name


def is_user_in_group(user, group):
    """
    Return True if user is in the group, False otherwise.

    Args:
      user(str): user name/id
      group(class:Group): group to check user membership against
    """
    # if user is in the group
    if user in group.get_users():
        return True

    else:
        for u in group.get_groups():
            return is_user_in_group(user,u)
        return False


    return None

parent = Group("parent")
child = Group("child")
sub_child = Group("subchild")
sub_child_child = Group("subchild.child")

sub_child_user = "sub_child_user"
sub_child.add_user(sub_child_user)

sub_child_user = "sub_child_user.ofChild" # adding user of the sub child.
sub_child_child.add_user(sub_child_user)

child.add_group(sub_child)
parent.add_group(child)
sub_child.add_user(sub_child_user)


# Unit testing.
userinfo = 'sub_child_user'
test = is_user_in_group(userinfo, parent)
print(test) # Expected result : True

userinfo = 'sub_child_user.ofChild'
test = is_user_in_group(userinfo, sub_child_child)
print(test) # Expected result : True


# function testing
# invalid user.
userinfo = 'sub_child_user.ofChild-invalid'
test = is_user_in_group(userinfo, sub_child_child)
print(test) # expected result : False


# Edge case testing.
# Testing: If user in the higher directory can be find in the sub directory.
userinfo = 'sub_child_user'
test = is_user_in_group(userinfo, sub_child_child)
print(test) # expected result : False
