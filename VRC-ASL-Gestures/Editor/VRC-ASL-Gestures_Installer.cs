#if VRC_SDK_VRCSDK3 && UNITY_EDITOR

using UnityEngine;
using UnityEditor;
using UnityEditor.Animations;
using AnimatorController = UnityEditor.Animations.AnimatorController;
using VRCAvatarDescriptor = VRC.SDK3.Avatars.Components.VRCAvatarDescriptor;
using VRC.SDK3.Avatars.ScriptableObjects;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.UIElements;

namespace I5UCC.VRCASLGestures
{
    public class VRCASLGestures : EditorWindow
    {
        private VRCAvatarDescriptor targetAvatar = null;
        private int ControllerType = 0;
        private int UseThumbparams = 1;
        private int UseVRCF = 0;
        private int DominantHand = 0;

        private GUIStyle titleStyle = null;
        private GUIStyle titleStyle2 = null;
        private GUIStyle errorStyle = null;
        private GUIStyle highlightedStyle = null;

        private AnimatorController animatorToAdd = null;
        private VRCExpressionParameters parametersToAdd = null;
        private VRCExpressionsMenu menuToAdd = null;

        private bool showInfo = false;

        private readonly string emptyControllerPath = "Packages/com.i5ucc.vrcaslgestures/Controllers/ASLGestures_Empty.controller";

        private readonly string[] controllerPath =
        {
            "Packages/com.i5ucc.vrcaslgestures/Controllers/IndexVR/Thumbparams/ASLGestures_Index_Thumbparams.controller",
            "Packages/com.i5ucc.vrcaslgestures/Controllers/IndexVR/Without/ASLGestures_Index_NoMod_RightHandDominant.controller",
            "Packages/com.i5ucc.vrcaslgestures/Controllers/IndexVR/Without/ASLGestures_Index_NoMod_LeftHandDominant.controller",
            "Packages/com.i5ucc.vrcaslgestures/Controllers/GeneralVR/ThumbParams/ASLGestures_GeneralVR_Thumbparams.controller",
            "Packages/com.i5ucc.vrcaslgestures/Controllers/GeneralVR/Without/ASLGestures_GeneralVR_RightHandDominant.controller",
            "Packages/com.i5ucc.vrcaslgestures/Controllers/GeneralVR/Without/ASLGestures_GeneralVR_LeftHandDominant.controller",
            "Packages/com.i5ucc.vrcaslgestures/Controllers/Combined/ASLGestures_Combined_Full.controller"
        };

        private readonly string[] vrcfPrefabPath = 
        {
            "Packages/com.i5ucc.vrcaslgestures/Controllers/IndexVR/Thumbparams/VRCF_ASLGestures_Index_Thumbparams.prefab",
            "Packages/com.i5ucc.vrcaslgestures/Controllers/IndexVR/Without/VRCF_ASLGestures_Index_NoMod_RightHandDominant.prefab",
            "Packages/com.i5ucc.vrcaslgestures/Controllers/IndexVR/Without/VRCF_ASLGestures_Index_NoMod_LeftHandDominant.prefab",
            "Packages/com.i5ucc.vrcaslgestures/Controllers/GeneralVR/ThumbParams/VRCF_ASLGestures_GeneralVR_Thumbparams.prefab",
            "Packages/com.i5ucc.vrcaslgestures/Controllers/GeneralVR/Without/VRCF_ASLGestures_GeneralVR_RightHandDominant.prefab",
            "Packages/com.i5ucc.vrcaslgestures/Controllers/GeneralVR/Without/VRCF_ASLGestures_GeneralVR_LeftHandDominant.prefab",
            "Packages/com.i5ucc.vrcaslgestures/Controllers/Combined/VRCF_ASLGestures_Combined_Full.prefab"
        };
        
        private readonly string[] parameterPath =
        {
            "Packages/com.i5ucc.vrcaslgestures/Controllers/IndexVR/Thumbparams/Parameters_ThumbParams.asset",
            "Packages/com.i5ucc.vrcaslgestures/Controllers/IndexVR/Without/Parameters_NoMod.asset",
            "Packages/com.i5ucc.vrcaslgestures/Controllers/IndexVR/Without/Parameters_NoMod.asset",
            "Packages/com.i5ucc.vrcaslgestures/Controllers/GeneralVR/ThumbParams/Parameters_GeneralVR_Thumbparams.asset",
            "Packages/com.i5ucc.vrcaslgestures/Controllers/GeneralVR/Without/Parameters_GeneralVR.asset",
            "Packages/com.i5ucc.vrcaslgestures/Controllers/GeneralVR/Without/Parameters_GeneralVR.asset",
            "Packages/com.i5ucc.vrcaslgestures/Controllers/Combined/Parameters_Combined.asset"
        };

        private readonly string[] menuPath =
        {
            "Packages/com.i5ucc.vrcaslgestures/Controllers/IndexVR/Thumbparams/Menu_Index_Mod.asset",
            "Packages/com.i5ucc.vrcaslgestures/Controllers/IndexVR/Without/Menu_Index_NoMod.asset",
            "Packages/com.i5ucc.vrcaslgestures/Controllers/IndexVR/Without/Menu_Index_NoMod.asset",
            "Packages/com.i5ucc.vrcaslgestures/Controllers/GeneralVR/ThumbParams/Menu_GeneralVR_Thumbparams.asset",
            "Packages/com.i5ucc.vrcaslgestures/Controllers/GeneralVR/Without/Menu_GeneralVR.asset",
            "Packages/com.i5ucc.vrcaslgestures/Controllers/GeneralVR/Without/Menu_GeneralVR.asset",
            "Packages/com.i5ucc.vrcaslgestures/Controllers/Combined/Menu_Combined.asset"
        };

        private readonly int[] cost =
        {
            17,
            1,
            1,
            33,
            9,
            9,
            51
        };

        private readonly int layerindex = 2; //Gesture Controller
        private int type = 0;

        [MenuItem("Tools/VRC-ASL_Gestures")]
        public static void Open()
        {
            GetWindow<VRCASLGestures>("VRC-ASL_Gestures");
        }

        private void OnGUI()
        {
            titleStyle = new GUIStyle()
            {
                fontSize = 14,
                fixedHeight = 28,
                fontStyle = FontStyle.Bold,
                normal = {
                    textColor = Color.white
                }
            };


            titleStyle2 = new GUIStyle()
            {
                fontSize = 23,
                fixedHeight = 28,
                fontStyle = FontStyle.Bold,
                normal = {
                    textColor = Color.white
                }
            };

            highlightedStyle = new GUIStyle()
            {
                fontStyle = FontStyle.Bold,
                normal = {
                    textColor = Color.white
                }
            };

            errorStyle = new GUIStyle()
            {
                fontStyle = FontStyle.Bold,
                normal = {
                    textColor = Color.red
                }
            };

            EditorGUILayout.Space();
            EditorGUILayout.Space();
            DrawSimple();
        }

        private void DrawSimple()
        {
            Texture banner = (Texture)AssetDatabase.LoadAssetAtPath("Packages/com.i5ucc.vrcaslgestures/VRC ASL.png", typeof(Texture));
            GUI.DrawTexture(new Rect(20, 10, 60, 60), banner, ScaleMode.StretchToFill, true, 10.0F);
            EditorGUILayout.Space(12);
            EditorGUILayout.LabelField("\tVRC-ASL_Gestures", titleStyle2);
            EditorGUILayout.Space(35);
            EditorGUILayout.LabelField("Avatar (Drag and Drop avatar here)", titleStyle);
            EditorGUILayout.Space();
            targetAvatar = EditorGUILayout.ObjectField(targetAvatar, typeof(VRCAvatarDescriptor), true, GUILayout.Height(30)) as VRCAvatarDescriptor;
            EditorGUILayout.Space();

            if (targetAvatar)
            {
                EditorGUILayout.LabelField("Controller Type", titleStyle);
                EditorGUILayout.Space();
                ControllerType = EditorGUILayout.Popup(ControllerType, new string[3] {
                    "Index",
                    "Oculus Touch",
                    "Combined"
                });

                if (ControllerType != 2) {
                    EditorGUILayout.Space();
                    EditorGUILayout.LabelField("Use Thumbparams?", titleStyle);
                    EditorGUILayout.Space();
                    if (GUILayout.Button("More information on Thumbparams"))
                        Application.OpenURL("https://github.com/I5UCC/VRCThumbParamsOSC");

                    UseThumbparams = EditorGUILayout.Popup(UseThumbparams, new string[2] {
                        "No",
                        "Yes"
                    });

                    if (UseThumbparams == 0)
                    {
                        EditorGUILayout.Space();
                        EditorGUILayout.LabelField("Dominant Hand", titleStyle);

                        DominantHand = EditorGUILayout.Popup(DominantHand, new string[2] {
                            "Right",
                            "Left"
                        });
                    }
                }

                type = GetControllerType();

                EditorGUILayout.Space();
                int TotalCost;
                if (targetAvatar.expressionParameters != null)
                    TotalCost = targetAvatar.expressionParameters.CalcTotalCost() + cost[type];
                else
                    TotalCost = cost[type];

                UseVRCF = EditorGUILayout.Popup("Use VRCFury Prefab?", UseVRCF, new string[2] {
                    "No",
                    "Yes"
                });

                showInfo = EditorGUILayout.Foldout(showInfo, "More Information", true);


                if (showInfo)
                {
                    EditorGUILayout.Space();
                    EditorGUILayout.LabelField("To add or merge:", highlightedStyle);
                    EditorGUILayout.LabelField(controllerPath[type].Substring(controllerPath[type].LastIndexOf("/") + 1));
                    EditorGUILayout.LabelField(parameterPath[type].Substring(parameterPath[type].LastIndexOf("/") + 1));
                    EditorGUILayout.LabelField(menuPath[type].Substring(menuPath[type].LastIndexOf("/") + 1));
                    EditorGUILayout.Space();
                }

                EditorGUILayout.Space();
                EditorGUILayout.LabelField("Memory needed: " + cost[type].ToString(), highlightedStyle);
                EditorGUILayout.LabelField("Total Memory: " + TotalCost.ToString() + "/256", highlightedStyle);

                if (TotalCost <= 256 && (targetAvatar.expressionsMenu == null || targetAvatar.expressionsMenu.controls.Count != 8))
                {
                    AnimatorController emptyAnimator = AssetDatabase.LoadAssetAtPath(emptyControllerPath, typeof(AnimatorController)) as AnimatorController;
                    animatorToAdd = AssetDatabase.LoadAssetAtPath(controllerPath[type], typeof(AnimatorController)) as AnimatorController;
                    parametersToAdd = AssetDatabase.LoadAssetAtPath(parameterPath[type], typeof(VRCExpressionParameters)) as VRCExpressionParameters;
                    menuToAdd = AssetDatabase.LoadAssetAtPath(menuPath[type], typeof(VRCExpressionsMenu)) as VRCExpressionsMenu;

                    if (targetAvatar.baseAnimationLayers[layerindex].animatorController == animatorToAdd)
                        GUI.enabled = false;
                    else
                        GUI.enabled = true;

                    if (GUILayout.Button("install"))
                    {
                        if (UseVRCF == 1)
                        {
                            VrcFuryPrefabAlreadySet();
                            if (targetAvatar.baseAnimationLayers[layerindex].isDefault || targetAvatar.baseAnimationLayers[layerindex].animatorController == null) {
                                targetAvatar.baseAnimationLayers[layerindex].animatorController = emptyAnimator;
                            }
                            targetAvatar.baseAnimationLayers[layerindex].isDefault = false;
                            GameObject vrcfPrefab = AssetDatabase.LoadAssetAtPath(vrcfPrefabPath[type], typeof(GameObject)) as GameObject;
                            GameObject vrcf = Instantiate(vrcfPrefab);
                            vrcf.name = vrcfPrefab.name;
                            vrcf.transform.parent = targetAvatar.transform;
                            vrcf.transform.localPosition = Vector3.zero;
                            vrcf.transform.localRotation = Quaternion.identity;
                            vrcf.transform.localScale = Vector3.one;
                            AssetDatabase.SaveAssets();
                            AssetDatabase.Refresh();
                            return;
                        }
                        targetAvatar.customizeAnimationLayers = true;
                        if (targetAvatar.baseAnimationLayers[layerindex].isDefault || targetAvatar.baseAnimationLayers[layerindex].animatorController == null || AnimatorAlreadySet())
                           targetAvatar.baseAnimationLayers[layerindex].animatorController = animatorToAdd;
                        else
                           MergeController(targetAvatar, animatorToAdd);
                        targetAvatar.baseAnimationLayers[layerindex].isDefault = false;

                        targetAvatar.customExpressions = true;
                        if (targetAvatar.expressionParameters == null)
                           targetAvatar.expressionParameters = parametersToAdd;
                        else
                           MergeParameters(targetAvatar, parametersToAdd);

                           
                        if (targetAvatar.expressionsMenu == null)
                           targetAvatar.expressionsMenu = menuToAdd;
                        else
                           MergeMenus(targetAvatar, menuToAdd);

                        AssetDatabase.SaveAssets();
                        AssetDatabase.Refresh();
                    }
                    
                }
                else if (targetAvatar.expressionsMenu.controls.Count == 8)
                {
                    GUI.enabled = false;
                    GUILayout.Button("Install");
                    GUI.enabled = true;

                    EditorGUILayout.LabelField("Not enough space in Menu!", errorStyle);
                }
                else
                {
                    GUI.enabled = false;
                    GUILayout.Button("Install");
                    GUI.enabled = true;

                    EditorGUILayout.LabelField("Not enough Parameter space!", errorStyle);
                }
            }
        }

        private int GetControllerType()
        {
            if (ControllerType == 0 && UseThumbparams == 1)
                return 0;
            else if (ControllerType == 0 && UseThumbparams == 0 && DominantHand == 0)
                return 1;
            else if (ControllerType == 0 && UseThumbparams == 0 && DominantHand == 1)
                return 2;
            else if (ControllerType == 1 && UseThumbparams == 1)
                return 3;
            else if (ControllerType == 1 && UseThumbparams == 0 && DominantHand == 0)
                return 4;
            else if (ControllerType == 1 && UseThumbparams == 0 && DominantHand == 1)
                return 5;
            else if (ControllerType == 2)
                return 6;
            return -1;
        }

        private void MergeParameters(VRCAvatarDescriptor descriptor, VRCExpressionParameters parametersToAdd)
        {
            VRCExpressionParameters parametersOriginal = (VRCExpressionParameters)descriptor.expressionParameters;
            List<VRCExpressionParameters.Parameter> addparams = new List<VRCExpressionParameters.Parameter>();
            
            for (int i = 0; i < parametersToAdd.parameters.Length; i++)
            {
                VRCExpressionParameters.Parameter p = parametersToAdd.parameters[i];
                if (!ParametersContainsParameter(parametersOriginal, p.name))
                {
                    VRCExpressionParameters.Parameter temp = new VRCExpressionParameters.Parameter
                    {
                        name = p.name,
                        valueType = p.valueType,
                        defaultValue = p.defaultValue,
                        saved = p.saved
                    };
                    addparams.Add(temp);
                }
                else
                    Debug.LogWarning(p.name + " parameter does already exist!");
            }

            EditorUtility.SetDirty(descriptor.expressionParameters);
            descriptor.expressionParameters.parameters = parametersOriginal.parameters.Concat(addparams.ToArray()).ToArray();
        }

        private void MergeMenus(VRCAvatarDescriptor descriptor, VRCExpressionsMenu menuToAdd)
        {
            VRCExpressionsMenu menuOriginal = (VRCExpressionsMenu)descriptor.expressionsMenu;
            foreach (VRCExpressionsMenu.Control c in menuToAdd.controls)
            {
                if (!MenuContainsControl(menuOriginal, c.name))
                {
                    VRCExpressionsMenu.Control temp = new VRCExpressionsMenu.Control
                    {
                        name = c.name,
                        icon = c.icon,
                        labels = c.labels,
                        parameter = c.parameter,
                        style = c.style,
                        subMenu = c.subMenu,
                        subParameters = c.subParameters,
                        type = c.type,
                        value = c.value
                    };

                    menuOriginal.controls.Add(temp);
                }
            }
            EditorUtility.SetDirty(descriptor.expressionsMenu);
        }

        private void MergeController(VRCAvatarDescriptor descriptor, AnimatorController controllerToAdd)
        {
            AnimatorController controllerOriginal = (AnimatorController)descriptor.baseAnimationLayers[2].animatorController;
            AvatarMask lefthandmask = AssetDatabase.LoadAssetAtPath("Packages/com.vrchat.avatars/Samples/AV3 Demo Assets/Animation/Masks/vrc_Hand Left.mask", typeof(AvatarMask)) as AvatarMask;
            AvatarMask righthandmask = AssetDatabase.LoadAssetAtPath("Packages/com.vrchat.avatars/Samples/AV3 Demo Assets/Animation/Masks/vrc_Hand Right.mask", typeof(AvatarMask)) as AvatarMask;

            for (int i = 1; i < controllerOriginal.layers.Length; i++)
                if (controllerOriginal.layers[i].avatarMask.Equals(lefthandmask) || controllerOriginal.layers[i].avatarMask.Equals(righthandmask))
                {
                    controllerOriginal.RemoveLayer(i);
                    i--;
                }   

            AnimatorCloner.MergeControllers(controllerOriginal, controllerToAdd);
        }
        private bool ParametersContainsParameter(VRCExpressionParameters c, string name)
        {
            foreach (VRCExpressionParameters.Parameter p in c.parameters)
                if (p.name == name)
                    return true;

            return false;
        }

        private bool MenuContainsControl(VRCExpressionsMenu c, string name)
        {
            foreach (VRCExpressionsMenu.Control p in c.controls)
                if (p.name == name)
                    return true;

            return false;
        }

        private bool VrcFuryPrefabAlreadySet()
        {
            string objectString = "VRCF_ASLGestures";
            foreach (Transform child in targetAvatar.transform)
            {
                if (child.name.Contains(objectString))
                {
                    DestroyImmediate(child.gameObject);
                    return true;
                }
            }
            return false;
        }

        private bool AnimatorAlreadySet()
        {
            for (int i = 0; i < controllerPath.Length; i++)
                if (targetAvatar.baseAnimationLayers[layerindex].animatorController.name + ".controller" == controllerPath[i].Substring(controllerPath[i].LastIndexOf("/") + 1))
                    return true;
            return false;
        }
    }
}

#endif